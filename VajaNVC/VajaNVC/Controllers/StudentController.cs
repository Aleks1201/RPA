using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VajaNVC.Models;

namespace VajaNVC.Controllers
{
    public class StudentController : Controller
    {
        List<student> studentList = new List<student>
            {
                new student() {StudentId=1, StudentName="John", Age=18 },
                new student() {StudentId=2, StudentName="Janez", Age=18 },
                new student() {StudentId=3, StudentName="Marija", Age=19 },
                new student() {StudentId=4, StudentName="Toni", Age=20 },
                new student() {StudentId=5, StudentName="Franci", Age=22 }

            };
        // GET: Student
        public ActionResult Index()
        {
           

            return View(studentList);
        }
        public ActionResult Edit (int id)
        {
            var študent = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(študent);
        }
        [HttpPost]
        public ActionResult Edit(student std)
        {
            if (ModelState.IsValid)
            {
                //posodobi podatke
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}