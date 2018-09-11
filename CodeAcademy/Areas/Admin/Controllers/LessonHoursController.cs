using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class LessonHoursController : Controller
    {
        AppDbContext _dbContext;

        public LessonHoursController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(LessonHourCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                LessonHour hour = new LessonHour()
                {
                    Name = model.Name,
                    BeginHour = (byte)model.BeginTime.Hour,
                    BeginMinute = (byte)model.BeginTime.Minute,
                    EndHour = (byte)model.EndTime.Hour,
                    EndMinute = (byte)model.EndTime.Minute,
                    Monday = model.Monday,
                    Friday = model.Friday,
                    Saturday = model.Saturday,
                    Sunday = model.Sunday,
                    Thursday = model.Thursday,
                    Tuesday = model.Tuesday,
                    Wednesday = model.Wednesday,
                    CreationDate=DateTime.Now
                };

                if (await _dbContext.LessonHours.AddAsync(hour) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                       return RedirectToAction("Index", "LessonHours");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Model is invalid...");
            }
            return RedirectToAction("Index", "LessonHours");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LessonHourViewModel model)
        {
          
            return RedirectToAction("Index", "LessonHours");
        }
    }
}