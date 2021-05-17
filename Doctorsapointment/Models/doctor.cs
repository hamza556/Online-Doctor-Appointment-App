using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctorsapointment.Models
{
    public class doctor
    {
        [Key]
        public int Regid { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter your Email ")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }
        
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }

        
        [Display(Name = "Designation ")]
        public string designation { get; set; }
        
        [Display(Name = "Speciality")]
        public string speciality { get; set; }
        
        [Display(Name = "PMDC")]
        [Required(ErrorMessage = "PMDC Number is required  ")]
        public string pmdc { get; set; }


        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password ")]
        public string password { get; set; }

       

    }
}