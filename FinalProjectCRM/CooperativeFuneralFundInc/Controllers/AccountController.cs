using Microsoft.AspNetCore.Mvc;
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
using Microsoft.AspNetCore.Authorization;

namespace CooperativeFuneralFundInc.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userMngr,
            SignInManager<User> signInMngr, CFFDataContext context)
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
            ViewBag.SecurityQuestion = _context.SecurityQuestions.ToList();


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            List<String> newUserRole = new List<string>();
            newUserRole.Add("Visitor");
            if (ModelState.IsValid)
            {

                var user = new User { UserName = model.Username, firstName = model.firstName, lastName = model.lastName, PhoneNumber = model.phoneNumber, numberType = model.numberType, securityQuestion = model.securityQuestion, securityAnswer = model.securityAnswer, Email = model.email, RoleNames = newUserRole };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    bool isPersistent = false;
                    await signInManager.SignInAsync(user, isPersistent);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.NumberType = _context.NumberTypes.ToList();
                    ViewBag.SecurityQuestion = _context.SecurityQuestions.ToList();
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

        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string username, string email, string firstname, string lastname)
        {
            if (ModelState.IsValid)
            {
                var checkedUser = _context.Users.Where(a => a.Email.Equals(email) && a.UserName.Equals(username) && a.firstName.Equals(firstname) && a.lastName.Equals(lastname)).FirstOrDefault();
                if (checkedUser != null)
                {
                    ViewBag.NameOfUser = checkedUser.firstName;
                    return View("ResetPassword", checkedUser);
                }
            }
            else
            {
                return RedirectToAction("ForgotPassword");
            }
            return RedirectToAction("ForgotPassword");
        }


        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(string password)
        {
            return RedirectToAction("LoginIndex");
        }


    }
}