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
        [Required(ErrorMessage ="ime je obvezen podatek")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage ="Starost je obvezen podatek")]
        [Range(18,50,ErrorMessage ="Napačna starost")]
        public int Age { get; set; }
    }
}