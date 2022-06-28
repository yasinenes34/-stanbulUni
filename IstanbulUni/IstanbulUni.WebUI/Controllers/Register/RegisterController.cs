
using IstanbulUni.WebUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IstanbulUni.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Register(User user)
        {
            return View(user);
             string email= user.Email;
            string password= user.Password;
            string password1 = user.Password;

        }



    }
}