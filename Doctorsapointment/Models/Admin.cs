using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctorsapointment.Models
{
    public class Admin
    {

        [Key]
        public int Adminid { get; set; }

        [Display(Name = "Admin Email")]
        public string email { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }
    }
}