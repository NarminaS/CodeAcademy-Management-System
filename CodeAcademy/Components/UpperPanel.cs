using CodeAcademy.Components.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        AppDbContext _dbContext;

        public UpperPanel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke(string email)   
        {
            var authenticated =  _dbContext.Users
                                        .Where(x => x.UserName == email)
                                                 .FirstOrDefaultAsync().Result;
            var path = _dbContext.ProfileImages.Where(x => x.User.Email == email).SingleOrDefaultAsync().Result.Path;
            _model = new UpperPanelViewModel() { Name = authenticated.Name, AvatarPath = path };
            return View(_model);
        }
    }
}
