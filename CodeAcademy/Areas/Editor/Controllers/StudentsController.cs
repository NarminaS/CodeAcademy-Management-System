using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Editor.Models;
using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class StudentsController : Controller
    {
        AppDbContext _dbContext;
        UserManager<User> _userManager;

        public StudentsController(AppDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _dbContext.Students.Include(g => g.Group)
                                             .Select(x => new StudentViewModel { Name = x.Name, Surname = x.Surname, GroupName = x.Group.Name })
                                                    .ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> Create(StudentCreateModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    BirthDate = model.BirthDate,
                    Group = await _dbContext.Groups.FirstOrDefaultAsync(x=>x.Id==model.GroupId),
                    CourseCompletionStatusId = 1,
                    CreatingDate = DateTime.Now,
                    Email = model.Email,
                    GenderId = (byte)model.GenderId,
                    ImageId = 1,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber
                };
                if (_userManager.FindByEmailAsync(model.Email).Result == null)
                {
                    var result = await _userManager.CreateAsync(student, model.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(student, "Student");
                        var urlHelper = HttpContext.RequestServices.GetRequiredService<IUrlHelper>();
                        await this.SendConfirmaitionMail(student, _userManager, urlHelper);
                        return Json(student.Name);

                    }
                    else
                    {
                        return Json("error adding student");
                    }
                }

            }
            return RedirectToAction("Index", "Students");
        }

        public async Task<IActionResult> GetGroupsByFaculty(int facultyId)
        {
            var groups = await _dbContext.Groups.Where(x => x.FacultyId == facultyId).ToListAsync();
            return Json(groups);
        }
    }
}