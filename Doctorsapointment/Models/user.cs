using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctorsapointment.Models
{
    public class user
    {
        public enum Gender
        {
            Male, Female
        }
        [Key]
        public int Userid { get; set; }
        [Required(ErrorMessage = "Enter your name ")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter your Phone ")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }

        [Required(ErrorMessage = "Enter your contact no ")]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Gender")]
        public Gender gndr { get; set; }

        [Required(ErrorMessage = "Enter your address ")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Enter your password ")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

       // [Required(ErrorMessage = "Password not matched ")]
        //[Display(Name = "Confirmm Password")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Password not match")]
        //public string Cpassword { get; set; }
    }
}