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
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<student>
            {
                new student() {StudentId=1, StudentName="John", Age=18 },
                new student() {StudentId=1, StudentName="Janez", Age=18 },
                new student() {StudentId=1, StudentName="Marija", Age=19 },
                new student() {StudentId=1, StudentName="Toni", Age=20 },
                new student() {StudentId=1, StudentName="Franci", Age=22 }

            };

            return View(studentList);
        }
    }
}