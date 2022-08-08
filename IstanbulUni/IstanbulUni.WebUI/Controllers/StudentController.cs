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
        #region Index
        [Authorize]
        public ActionResult Index()
        {
            var userval = sm.GetListBl();
            return View(userval);
        }
        #endregion
        #region List
        //[Route("studentlist")]
        [Authorize]
        public ActionResult StudentList()
        {
            var userval = sm.GetListBl();
            return View(userval);
        }
        #endregion
        #region Add
        [Authorize]
        public ActionResult StudentAdd(Student student)
        {
            StudentValidator validations = new StudentValidator();
            ValidationResult result = validations.Validate(student);
            if (result.IsValid)
            {
                sm.StudentAddBl(student);
                return RedirectToAction("Index");
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
        #endregion
        // GET: Student
        #region Update
        [HttpGet]
        [Authorize]
        public ActionResult StudentUpdate(int id)
        {
            var student = sm.GetByID(id);
            return View(student);
        }
        [HttpPost]
        [Authorize]
       
        public ActionResult StudentUpdate(Student student)
        {
            StudentValidator validations = new StudentValidator();
            ValidationResult result = validations.Validate(student);
            if (result.IsValid)
            {
                sm.StudentUpdate(student);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }
            }

            return View(student);
        }
        #endregion


        #region Delete
       
        public ActionResult DeleteStudent(int id)
        {
            var student = sm.GetByID(id);
            sm.StudentRemoveBl(student);

            return RedirectToAction("Index", "Student");
        }
        #endregion

    }
}