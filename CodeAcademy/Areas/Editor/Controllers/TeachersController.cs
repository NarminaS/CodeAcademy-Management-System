using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Services;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class TeachersController : Controller
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;

        public TeachersController(AppDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult List() 
        {
            var model = _dbContext.Teachers.Include(x=>x.ProfileImage)
                                           .ThenInclude(x=>x.Path)
                                                .Include(x=>x.Faculty)
                                                 .ThenInclude(x=>x.Name)
                                                    .Select(x => new TeacherViewModel()
                                 { Name = x.Name, Surname = x.Surname, FacultyName = x.Faculty.Name, PhotoPath = x.ProfileImage.Path }).ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult>Create(TeacherCreateModel model)
        {
            if (ModelState.IsValid)
            {
                Teacher teacher = new Teacher()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    BirthDate = model.BirthDate,
                    Faculty = await _dbContext.Faculties.FirstOrDefaultAsync(x => x.Id == model.FacultyId),
                    GenderId = (byte)model.GenderId,
                    Email = model.Email,
                    UserName = model.Email,
                    CreatingDate = DateTime.Now,
                    ImageId = 1,
                    PhoneNumber = model.PhoneNumber
                };
                if (_userManager.FindByEmailAsync(model.Email).Result == null)
                {
                    try
                    {
                        var result = await _userManager.CreateAsync(teacher, model.Password);
                        if (result.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(teacher, "Teacher");
                            await SendConfirmaitionMail(teacher);
                            return RedirectToAction("List", "Teachers");
                        }
                        else
                        {
                           ModelState.AddModelError("", "Something wrong");
                        }
                    }
                    catch (Exception ex)
                    {
                        //  
                    }
                }
                else
                {
                    ModelState.AddModelError("", $"User with {model.Email} email already exists");
                }
            }
            return RedirectToAction("List", "Teachers");
        }

        [HttpGet]
        public IActionResult GetFaculties()
        {
            var data = _dbContext.Faculties.Select(x => new FacultyViewModel() { Id = x.Id, Name = x.Name }).ToList();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetGenders()
        {
            var data = _dbContext.Genders.ToList();
            return Json(data);
        }

        private async Task SendConfirmaitionMail(User user)
        {
            
            try
            {
                var _code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmEmail",
                                                "Account",
                                                new { userId = user.Id, code = _code },
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