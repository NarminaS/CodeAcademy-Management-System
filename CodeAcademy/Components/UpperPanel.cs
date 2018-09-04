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
                                            .Include(x => x.ProfileImage)
                                                .FirstOrDefaultAsync().Result;
            _model = new UpperPanelViewModel() { Name = authenticated.Name, AvatarPath = authenticated.ProfileImage.Path };
            return View(_model);
        }
    }
}
