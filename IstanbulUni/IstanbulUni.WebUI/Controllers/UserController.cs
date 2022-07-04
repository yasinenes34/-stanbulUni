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
using System.Web.Security;

namespace IstanbulUni.WebUI.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        #region Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(User user)
        {
            bool userVarMi = um.UserLogin(user);


            if (userVarMi)
            {
                FormsAuthentication.SetAuthCookie(user.Email, false);

                return Json(userVarMi, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(userVarMi, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region Register
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
        #endregion

        public ActionResult Logout()
        {
            Session.RemoveAll();
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "User");
        }
        public ActionResult Toast()
        {
            
            return View();
        }
       
    }

}
