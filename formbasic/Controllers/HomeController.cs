using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using formbasic.Models;

namespace formbasic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            pradeepEntities db = new pradeepEntities();

            List<employee> em = db.employees.ToList();
            ViewBag.employ = new SelectList(em, "Id", "name");


            return View();
        }

        public ActionResult Record(custommodel model)
        {
            pradeepEntities db = new pradeepEntities();

            employee emp = new employee();
          
            emp.name = model.name;
            emp.post = model.post;

            db.employees.Add(emp);

            db.SaveChanges();


            return RedirectToAction("Index");

        }
    }
}