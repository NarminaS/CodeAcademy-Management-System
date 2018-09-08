using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class StatusCodeController : Controller
    {

        public IActionResult Status(int id)   
        {
            if (!User.Identity.IsAuthenticated)
            {
                id = 401;
            }

            if (Request.HttpContext.Features.Get<IHttpRequestFeature>().RawTarget.ToLower().Contains("accessdenied"))
            {
                id = 403;
            }

            return View(id);
        }
    }
}