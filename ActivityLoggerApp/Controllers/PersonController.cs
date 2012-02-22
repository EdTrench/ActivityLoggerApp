using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            PersonRepositry PersonRepositry = new PersonRepositry();
            var model = PersonRepositry.GetAll();
            return View(model);
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(Int64 id)
        {
            PersonRepositry PersonRepositry = new PersonRepositry();
            var model = PersonRepositry.GetById(id);
            return View(model);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            var model = new Person();
            return View(model);
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                PersonRepositry PersonRepositry = new PersonRepositry();
                PersonRepositry.Add(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(Int64 id)
        {
            PersonRepositry personRepositry = new PersonRepositry();
            BikeRepositry bikeRepositry = new BikeRepositry();
            
            var model = personRepositry.GetById(id);
            ViewBag.Bikes = bikeRepositry.GetByPersonId(id);
            
            return View(model);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            try
            {
                PersonRepositry PersonRepositry = new PersonRepositry();
                PersonRepositry.Update(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(Int64 id)
        {
            PersonRepositry PersonRepositry = new PersonRepositry();
            var model = PersonRepositry.GetById(id);
            return View(model);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost]
        public ActionResult Delete(Person person)
        {
            try
            {
                PersonRepositry PersonRepositry = new PersonRepositry();
                PersonRepositry.Remove(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}