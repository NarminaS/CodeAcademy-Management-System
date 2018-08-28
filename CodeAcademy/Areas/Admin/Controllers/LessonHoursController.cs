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
            var hours = _dbContext.LessonHours
                            .Select(x => new LessonHourViewModel()
                            { Id = x.Id, Name = x.Name })
                                    .ToList();
            return View(hours);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LessonHourCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                LessonHour hour = new LessonHour() { Name = model.Name };
                if (await _dbContext.AddAsync(hour) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "LessonHours");
                    }
                    else
                    {
                        //SQL EXCEPTION....
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Enter correct data...");
            }
            return RedirectToAction("Index", "LessonHours");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LessonHourViewModel model)
        {
            if (ModelState.IsValid)
            {
                var hour = _dbContext.LessonHours.Where(x => x.Id == model.Id).SingleOrDefault();
                if (hour != null && hour.Name != model.Name)
                {
                    hour.Name = model.Name;
                    _dbContext.Update(hour);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "LessonHours");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Change name...");
                }
            }
            else
            {
                ModelState.AddModelError("", "Something is wrong...");
            }
            return RedirectToAction("Index", "LessonHours");
        }
    }
}