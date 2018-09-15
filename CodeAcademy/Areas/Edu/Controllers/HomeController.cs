using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.Areas.Edu.Controllers
{
    [Authorize(Roles = "Student,Teacher")]
    [Area("Edu")]
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllPosts()
        {
            var allArticles = await _dbContext.Articles.Include(x=>x.User).Include(x=>x.PostImages).ToListAsync();
            var allQuestions = await _dbContext.Questions.Include(x => x.User).Include(x => x.PostImages).ToListAsync();

            return Json("ok");
        }
    }
}