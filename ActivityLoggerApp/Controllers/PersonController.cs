using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Controllers;
using ActivityLoggerApp.Helpers;

namespace ActivityLoggerApp.Controllers.Persons
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            var id = ModelExtensions.GetUserId();
            PersonRepository ridePersonRepositry = new PersonRepository();
            //var model = ridePersonRepositry.GetByUserId(id);
            var model = ridePersonRepositry.GetAll();
            return View(model);
        }

        //
        // GET: /Person/Details/5
        public  ActionResult Details(Int64 id)
        {
            PersonRepository ridePersonRepositry = new PersonRepository();
            var model = ridePersonRepositry.GetById(id);
            return View(model);
        }

        //
        // GET: /Person/Create
        public  ActionResult Create()
        {
            var model = new Person();
            return View(model);
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public  ActionResult Create(Person person)
        {
            try
            {
                PersonRepository RidePersonRepositry = new PersonRepository();
                RidePersonRepositry.Add(person);
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
            PersonRepository ridePersonRepositry = new PersonRepository();
            BikeRepositry bikeRepositry = new BikeRepositry();

            var model = ridePersonRepositry.GetById(id);
            ViewBag.Bikes = bikeRepositry.GetByPersonId(id);

            return View(model);
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        public  ActionResult Edit(Person person)
        {
            try
            {
                PersonRepository ridePersonRepositry = new PersonRepository();
                ridePersonRepositry.Update(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5
        public  ActionResult Delete(Int64 id)
        {
            PersonRepository ridePersonRepositry = new PersonRepository();
            var model = ridePersonRepositry.GetById(id);
            return View(model);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost]
        public  ActionResult Delete(Person person)
        {
            try
            {
                PersonRepository ridePersonRepositry = new PersonRepository();
                ridePersonRepositry.Remove(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}