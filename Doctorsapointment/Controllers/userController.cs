using Doctorsapointment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doctorsapointment.Controllers
{
    public class userController : Controller
    {
        Model db = new Model();
        // GET: user
        [HttpGet]
        public ActionResult register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult register(user u)
        {
            if (ModelState.IsValid)
            {

                db.users.Add(u);
                db.SaveChanges();
                return RedirectToAction("index", "Home");
            }
            //catch (DbEntityValidationException ex)
            //{
              //  foreach (var entityValidationErrors in ex.EntityValidationErrors)
                //{
                  //  foreach (var validationError in entityValidationErrors.ValidationErrors)
                   // {
                     //   Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    //}
                //}
                
            //}
            return View();
        }
    }
}