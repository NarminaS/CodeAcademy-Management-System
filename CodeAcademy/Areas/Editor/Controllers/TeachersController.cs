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
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class TeachersController : Controller
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;
        IUrlHelperFactory _urlHelperFactory;
        IActionContextAccessor _actionAccessor;

        public TeachersController(AppDbContext dbContext, UserManager<User> userManager, IUrlHelperFactory urlHelperFactory, IActionContextAccessor actionAccessor)
        {
            _dbContext = dbContext;
            _urlHelperFactory = urlHelperFactory;
            _userManager = userManager;
            _actionAccessor = actionAccessor;
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
                            var urlHelper = HttpContext.RequestServices.GetRequiredService<IUrlHelper>();
                            await this.SendConfirmaitionMail(teacher,_userManager,urlHelper);
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
    }
}