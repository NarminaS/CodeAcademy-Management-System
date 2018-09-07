using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class EditorsController : Controller
    {
        UserManager<User> _userManager;
        AppDbContext _context;

        public EditorsController(UserManager<User> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult List()
        {
            var editors = _userManager.GetUsersInRoleAsync("Editor").Result
                                .Select(x=>new UserViewModel { Id=x.Id, Email=x.UserName, GenderId = x.GenderId, Name = x.Name }).ToList();
            return View(editors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EditorCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User editor = new User()
                {
                    UserName = model.Email,
                    GenderId = model.GenderId,
                    Name = model.Name,
                    Email = model.Email,
                    CreatingDate = DateTime.Now,
                    ImageId = 1
                };
                if (_userManager.FindByEmailAsync(model.Email).Result == null)
                {
                    try
                    {
                        var result = await _userManager.CreateAsync(editor, model.Password);
                        if (result.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(editor, "Editor");
                            await SendConfirmaitionMail(editor);
                            JsonResult js = Json(editor);
                            return js;
                        }
                        else
                        {
                            foreach (IdentityError error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
                ModelState.AddModelError("", $"User with {model.Email} email already exists");
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
           User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                try
                {
                   IdentityResult result = await _userManager.DeleteAsync(user);
                    if (result.Succeeded)
                    {
                        return Json("ok");
                    }
                }
                 catch (Exception ex)
                {

                }
            }
           return Json("List");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string email, string name, byte genderId)
        {
            User user = await _userManager.FindByNameAsync(email.Trim());
            if (user != null)
            {
                if (user.Name != name)
                {
                    user.Name = name;
                }

                if (user.GenderId != genderId)
                {
                    user.GenderId = genderId;
                }

                user.LastUpdateDate = DateTime.Now;

                IdentityResult result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("List");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return RedirectToAction("List");
        }

        private async Task SendConfirmaitionMail(User user)
        {
            try
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmEmail",
                                                "Account",
                                                new { userId = user.Id, code = code },
                                                protocol: HttpContext.Request.Scheme);
                await new EmailService().SendEmailAsync(user.Name, user.Email, $"CodeAcademy - {user.Name} - confirmation",
                                                        $"Sorry, I'm Narmina from P305, just testing my app. Confirm your registration via this link: <a href='{callbackUrl}'>link</a>");
            }
            catch (Exception ex)
            {
               //
            }

        }
    }
}