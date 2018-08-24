using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
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

        public EditorsController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult List()
        {
            var editors = _userManager.GetUsersInRoleAsync("Editor").Result
                                .Select(x=>new UserViewModel { Id=x.Id, Email=x.UserName, GenderId = x.GenderId, Name = x.Name }).ToList();
            return View(editors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            string defaultAvatarPath = "/images/avatars/avatar-default.png";
            if (ModelState.IsValid)
            {
                User editor = new User()
                                    {
                                      UserName = model.Email,
                                      GenderId = model.GenderId,
                                      Name = model.Name,
                                      Email = model.Email,
                                      CreatingDate = DateTime.Now,
                                      ProfilePhotoPath = defaultAvatarPath
                                    };
                if (_userManager.FindByEmailAsync(model.Email).Result == null)
                {
                    var result = await _userManager.CreateAsync(editor, model.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(editor, "Editor");
                        JsonResult js = Json(editor);
                        return RedirectToAction(nameof(List));
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
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
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("List");
                }
            }
           return RedirectToAction("List");
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
    }
}