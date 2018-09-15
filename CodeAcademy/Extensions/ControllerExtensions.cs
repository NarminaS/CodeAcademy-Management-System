using CodeAcademy.Models;
using CodeAcademy.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace CodeAcademy.Utilities
{
    public static class ControllerExtensions
    {
        public static async Task SendConfirmaitionMail(this Controller controller, User user, UserManager<User> userManager,IUrlHelper urlHelper)
        {

                var _code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = urlHelper.Action("ConfirmEmail",
                                                "Account",
                                                new { userId = user.Id, code = _code },
                                                protocol: controller.HttpContext.Request.Scheme);
                await new EmailService().SendEmailAsync(user.Name, user.Email, $"CodeAcademy - {user.Name} - confirmation",
                                                        $"Sorry, I'm Narmina from P305, just testing my app. Confirm your registration via this link: <a href='{callbackUrl}'>link</a>");
            

        }
    }
}
