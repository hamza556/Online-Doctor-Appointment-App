using Doctorsapointment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doctorsapointment.Controllers
{
    public class AccountController : Controller
    {
        Model db = new Model();
        // GET: Account

        [HttpGet]
        public ActionResult register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult register(doctor dr)
        {
            if (ModelState.IsValid)
            {
                db.doctors.Add(dr);
                db.SaveChanges();

                return RedirectToAction("index", "Home");
            }
 
            return View();




           // public ActionResult Index()
        //{
        //    return View();
        }
    }
}