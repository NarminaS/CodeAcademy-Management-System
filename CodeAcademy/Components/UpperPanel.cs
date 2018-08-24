using CodeAcademy.Components.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Components
{
    [ViewComponent(Name = "UpperPanel")]
    public class UpperPanel:ViewComponent
    {
        UpperPanelViewModel _model;
        UserManager<User> _userManager;

        public UpperPanel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke(string email)
        {
            var authenticated = _userManager.FindByEmailAsync(email).Result;
            _model = new UpperPanelViewModel() { Name = authenticated.Name, AvatarPath = authenticated.ProfilePhotoPath };
            return View(_model);
        }
    }
}
