using FluentValidation.Results;
using IstanbulUni.BAL.Concrete;
using IstanbulUni.BAL.Validation;
using IstanbulUni.DAL.EntityFramework;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IstanbulUni.WebUI.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentDal());
      
        // GET: Student
        public ActionResult Index()
        {
            var userval = sm.GetListBl();
            return View(userval);
        }
        public ActionResult StudentList()
        {
            var userval = sm.GetListBl();
            return View(userval);
        }
        public ActionResult StudentAdd(Student student)
        {
            StudentValidator validations = new StudentValidator();
            ValidationResult result = validations.Validate(student);
            if (result.IsValid)
            {
                sm.StudentAddBl(student);
                return RedirectToAction("StudentList");
            }
            else
            {
                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }

            return View();
        }
        public ActionResult StudentUpdate(Student student)
        {
            StudentValidator validations = new StudentValidator();
            ValidationResult result = validations.Validate(student);
            if (result.IsValid)
            {
                
                return RedirectToAction("StudentList");
            }
            else
            {
                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }

            return View();
        }


       
        public ActionResult DeleteStudent(int id)
        {
            var studentInfo = sm.GetByID(id);
           

            return View();
        }
    }
}