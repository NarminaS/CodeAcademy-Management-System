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
    public class CourseCompletionStatusController : Controller
    {
        AppDbContext _dbContext;

        public CourseCompletionStatusController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _dbContext.CourseCompletionStatuses
                                    .Select(x => new CourseCompletionStatusViewModel()
                                        { Id = x.Id, Name = x.Name })
                                            .ToList();
            return View(items);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCompletionStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                CourseCompletionStatus status = new CourseCompletionStatus() { Name = model.Name };
                if (await _dbContext.CourseCompletionStatuses.AddAsync(status) != null)
                {
                    if ( await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "CourseCompletionStatus");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Please try again");
            }
            return RedirectToAction("Index", "CourseCompletionStatus");
        }

        [HttpPost]
        public  async Task<IActionResult> Edit(CourseCompletionStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                var status = _dbContext.CourseCompletionStatuses.Where(x => x.Id == model.Id).SingleOrDefault();
                if (status != null)
                {
                    status.Name = model.Name;
                    _dbContext.Update(status);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "CourseCompletionStatus");
                    }
                    else
                    {
                        //SQL EXCEPTION...
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Enter correct data...");
            }
            return RedirectToAction("Index", "CourseCompletionStatus");
        }
    }
}