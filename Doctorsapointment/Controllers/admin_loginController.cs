using Doctorsapointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doctorsapointment.Controllers
{
    public class admin_loginController : Controller
    {
        Model db = new Model();
        // GET: admin_login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var data = db.Admins.Where(s => s.email.Equals(admin.email) && s.password.Equals(admin.password)).ToList();
            if(data.Count() == 0)
            {
                return RedirectToAction("index", "Home");
            }
            
            return View();
        }
    }
}