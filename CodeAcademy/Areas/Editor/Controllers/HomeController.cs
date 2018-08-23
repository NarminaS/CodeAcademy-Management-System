using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles ="Editor")]
    [Area("Editor")]
    public class HomeController : Controller
    {
        SignInManager<User> _signInManager;
        UserManager<User> _userManager;

        public HomeController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {  
            return View();
        }
    }
}