using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using CodeAcademy.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class GroupsController : Controller
    {
        AppDbContext _dbContext;
        IHostingEnvironment _environment;

        public GroupsController(AppDbContext dbContext,IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var groups = _dbContext.Groups
                .Include(i=>i.Image)
                .Select(x => new GroupViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    LessonsStartDate = x.LessonsStartDate,
                    LessonsEndDate = x.LessonsEndDate,
                    LogoPath = x.Image.Path
                }).ToList();

            return View(groups);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GroupCreateModel model, IFormFile file)
        {
            if (ModelState.IsValid && file != null)
            {
                Image img = new Image() { Path = Path.Combine("/images", file.FileName) };
                await _dbContext.Images.AddAsync(img);
                await Uploader.UploadToServer(new Uploader(_environment).DefineImagePath(file), file);

                Group group = new Group()
                {
                    Faculty = _dbContext.Faculties.Where(x=>x.Id==model.FacultyId).FirstOrDefault(),
                    CourseCompletionStatusId = 1,
                    CreationDate = DateTime.Now,
                    IsDeleted = false,
                    LessonHourId = model.HourId,
                    RoomId = model.RoomId,
                    Name = model.Name,
                    LessonsStartDate = model.StartDate,
                    LessonsEndDate = model.EndDate,
                    Teacher = _dbContext.Teachers.FirstOrDefault(x => x.Id == model.TeacherId),
                    ImageId = img.Id
                };
                await _dbContext.Groups.AddAsync(group);
                if (await _dbContext.SaveChangesAsync() > 0)
                {
                    return Json("Ok!");
                }
            }
            else
            {
                ModelState.AddModelError("", "Something is wrong");
            }
            return RedirectToAction("Index", "Groups");
        }

        public ActionResult GetRooms()
        {
            var rooms = _dbContext.Rooms.ToList();
            return Json(rooms);
        }

        public IActionResult GetLessonHours()
        {
            var hours = _dbContext.LessonHours.ToList();
            return Json(hours);
        }

        public IActionResult GetTeachersByFaculty(int facultyId)
        {
            var teachers = _dbContext.Teachers.Where(x => x.FacultyId == facultyId).ToList();
            return Json(teachers);
        }
    }
}