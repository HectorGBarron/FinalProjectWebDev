﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CooperativeFuneralFundInc.Models;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using CooperativeFuneralFundInc.Models.TasksManagement;
using CooperativeFuneralFundInc.Models.UserManagement;


namespace CooperativeFuneralFundInc.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userMngr,
            SignInManager<User> signInMngr, CFFDataContext context )
        {
            userManager = userMngr;
            signInManager = signInMngr;
            _context = context;


        }

        private readonly CFFDataContext _context;

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.NumberType = _context.NumberTypes.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username };
                user.firstName = model.firstName;
                user.lastName = model.lastName;
                user.PhoneNumber = model.phoneNumber;
                user.numberType = model.numberType;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    bool isPersistent = false;
                    await signInManager.SignInAsync(user, isPersistent);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                        Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

        public ViewResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult LoginIndex()
        {
            return View("Login");
        }
    }
}