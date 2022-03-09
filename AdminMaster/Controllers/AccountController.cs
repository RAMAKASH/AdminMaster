using AdminMaster.Respository.Interface;
using AdminMaster.Utils.Enums;
using AdminMaster.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminMaster.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsers UserService;
        public AccountController(IUsers users)
        {
            UserService = users;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(SignInModel Model)
        {
            if (ModelState.IsValid) 
            { 
                 var result= UserService.SignIn(Model);
                if(result== SignInEnum.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (result == SignInEnum.WrongCredentials)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login credentials!");
                }
                
                    else if (result == SignInEnum.NotVerified)
                    {
                    ModelState.AddModelError(string.Empty, "IUser not verified please verifiy first!");

                }
                else if (result == SignInEnum.InActive)
                    {
                    ModelState.AddModelError(string.Empty, " Your account is inactive! ");
                }
                }
            return View();
        }
    }
}
