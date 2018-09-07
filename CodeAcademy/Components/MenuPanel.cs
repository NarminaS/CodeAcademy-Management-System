using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace CodeAcademy.Components
{
    [ViewComponent(Name ="MenuPanel")]
    public class MenuPanel:ViewComponent
    {
        public MenuPanel()
        {

        }
        public IViewComponentResult Invoke(string email)
        {
            return View();
        }
    }
}
