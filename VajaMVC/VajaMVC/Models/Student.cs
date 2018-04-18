using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage ="NAROBE NOOOOO... napačen podatek ime.")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage = "NAROBE NOOOOO... napačen podatek starosti.")]
        [Range(18,50, ErrorMessage = "NAROBE NOOOOO... med 18 in 50.")]
        public int Age { get; set; }


    }
}