using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Models;
using CodeAcademy.Models.ViewModels;
using CodeAcademy.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class AccountController : Controller
    {
        UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    var _code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var callbackUrl = Url.Action(
                                                 "ResetPassword", "Account",
                                                  new { userId = user.Id, code = _code },
                                                  protocol: HttpContext.Request.Scheme
                                                 );
                    await new EmailService().SendEmailAsync(user.Name, model.Email, $"{user.Name} - Password reset",
                                                            $"Sorry, it's Narmina from P305 testing my app. To reset click: <a href='{callbackUrl}'>link</a> ");
                    return View("ForgotPasswordConfirmation");
                }
                catch (Exception ex)
                {
                    //
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation(string code = null)
        {
            return code == null ? View("Error") : View();

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code , string userId)
        {
            ResetPasswordViewModel model = new ResetPasswordViewModel() { UserId = userId, Code = code };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                var reset = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
                if (reset.Succeeded)
                {
                    return RedirectToAction("ResetPasswordConfirmation", "Account");
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

    }
}