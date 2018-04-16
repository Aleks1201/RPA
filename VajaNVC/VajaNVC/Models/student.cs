using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaNVC.Models
{
    public class student
    {
        public int StudentId { get; set; }
        [Display(Name="Ime")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        public int Age { get; set; }
    }
}