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
using System.Security.Cryptography;
using System.Text;

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
        public async Task<IActionResult> ForgotPassword(string username, string email, string firstname, string lastname)
        {
            if (ModelState.IsValid)
            {
                var checkedUser = _context.Users.Where(a => a.Email.Equals(email) && a.UserName.Equals(username) && a.firstName.Equals(firstname) && a.lastName.Equals(lastname)).FirstOrDefault();
                var token = await userManager.GeneratePasswordResetTokenAsync(checkedUser);
                if (checkedUser != null)
                {
                    TempData["userEmail"] = checkedUser.Email;
                    TempData["userName"]= checkedUser.UserName;
                    //ViewBag.NameOfUser = checkedUser.firstName;
                    return RedirectToAction("ResetPassword", checkedUser);
                }
            }
            else
            {
                return RedirectToAction("ForgotPassword");
            }
            return RedirectToAction("ForgotPassword");
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(User user)
        {
            string fullName = user.firstName + " " + user.lastName;
            ViewBag.NameOfUser = fullName;
            ViewBag.User = user;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(string password)
        {
            var userEmail = "";
            var userName = "";
            if (ModelState.IsValid)
            {
                if (TempData.ContainsKey("userName"))
                {
                    userName = TempData["userName"] as string;
                }
               
                var nameConfirm = await userManager.FindByNameAsync(userName);
                if (nameConfirm != null)
                {
                    nameConfirm.PasswordHash = HashPassword(password);
                    var newUser = await userManager.UpdateAsync(nameConfirm);
                    if (!newUser.Succeeded)
                    {
                        foreach (var error in newUser.Errors)
                            ModelState.AddModelError(error.Code, error.Description);
                        return View();
                    }
                    else

                        return RedirectToAction("ResetConfirm");
                }
                
            }
            return View("ResetPassword");
        }

        public IActionResult ResetConfirm()
        {
            return View();
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

    }
}