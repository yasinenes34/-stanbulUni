using FluentValidation.Results;
using IstanbulUni.BAL.Concrete;
using IstanbulUni.BAL.Validation;
using IstanbulUni.DAL.EntityFramework;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IstanbulUni.WebUI.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
       public ActionResult Login(User user)
        {
            bool userVarMi = um.UserLogin(user);
            if (userVarMi)
            {
                return RedirectToAction("StudentList","Student");
            }
            else
                return RedirectToAction("Login");


        }
        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(user);
            bool userVarMi = um.UserLogin(user);
            if (userVarMi)
            {
                return RedirectToAction("Register");
            }
            else
            {
                if (result.IsValid)
                {
                    um.UserAddBl(user);
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var i in result.Errors)
                    {
                        ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                    }
                }
            }
           

            return View();
        }
    }
  
}
