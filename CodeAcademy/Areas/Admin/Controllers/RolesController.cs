using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RolesController : Controller
    {
        UserManager<User> _userManager;
        RoleManager<Role> _roleManager;
        AppDbContext _dbContext;

        public RolesController(RoleManager<Role> roleManager, AppDbContext dbContext, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _dbContext.Roles.ToList();

            // declare list of users in each role
            List<int> userCount = new List<int>();

            var model = roles.Select(x => new RoleViewModel() { Id = x.Id, Name = x.Name}).ToList();

            for (int i = 0; i < roles.Count; i++)
            {
                userCount.Add(_userManager.GetUsersInRoleAsync(roles[i].Name).Result.Count);
                model[i].UsersInRoleCount = userCount[i];
            }
            model.ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                if (_roleManager.FindByNameAsync(name).Result==null)
                {
                    Role role = new Role() { Name = name };
                    var result = await _roleManager.CreateAsync(role);
                    if (result.Succeeded)
                    {
                        return Json(role);
                    }
                }
            }
            return RedirectToAction("Index","Roles");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Deactivate()
        {
            return View();
        }

        public IActionResult Reactivate()
        {
            return View();
        }
    }
}