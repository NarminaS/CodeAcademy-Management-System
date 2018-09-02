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
        public async Task<IActionResult> Create(LessonHour model)
        {
           
            return RedirectToAction("Index", "LessonHours");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LessonHourViewModel model)
        {
          
            return RedirectToAction("Index", "LessonHours");
        }
    }
}