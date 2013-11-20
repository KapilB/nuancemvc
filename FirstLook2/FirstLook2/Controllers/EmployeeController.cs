using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook2.Models;

namespace FirstLook2.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext db = new EmployeeDbContext();

        public ActionResult List()
        {
            var results = db.Employees.ToList();

            return Json(results, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Employee/
        public ActionResult Index(string searchTerm)
        {
            var results = db.Employees.Where(
                   e => searchTerm == null ||
                       e.FirstName.Contains(searchTerm) ||
                       e.LastName.Contains(searchTerm)).
                       ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Results", results);
            }
            else
            {
                return View(results);
            }
        }

        //
        // GET: /Employee/Details/5
        public ActionResult EmpDetails(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id = 0)
        {
            ViewData["Location"] = "Banglaore";

            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}