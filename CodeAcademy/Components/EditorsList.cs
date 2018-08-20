using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Components
{
    [ViewComponent(Name ="EditorsList")]
    public class EditorsList: ViewComponent
    {
        public List<UserViewModel> editors;
        UserManager<User> _userManager;

        public EditorsList(UserManager<User> userManager)
        {
            _userManager = userManager;
            editors = _userManager.GetUsersInRoleAsync("Editor").Result
                         .Select(x => new UserViewModel { Email = x.UserName }).ToList();
        }

        public IViewComponentResult Invoke()
        {
            return View(editors);
        }
    }
}
