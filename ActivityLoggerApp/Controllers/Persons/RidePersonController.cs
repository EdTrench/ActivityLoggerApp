using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Repositories.Persons;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Models.Persons;
using ActivityLoggerApp.Controllers;

namespace ActivityLoggerApp.Controllers.Persons
{
    public class RidePersonController : PersonController
    {
        //
        // GET: /Person/
        public override ActionResult Index()
        {
            RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
            var model = ridePersonRepositry.GetAll();
            return View(model);
        }

        //
        // GET: /Person/Details/5
        public override ActionResult Details(Int64 id)
        {
            RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
            var model = ridePersonRepositry.GetById(id);
            return View(model);
        }

        //
        // GET: /Person/Create
        public override ActionResult Create()
        {
            var model = new RidePerson();
            return View(model);
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public override ActionResult Create(Person person)
        {
            try
            {
                RidePersonRepositry RidePersonRepositry = new RidePersonRepositry();
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
        public override ActionResult Edit(Int64 id)
        {
            RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
            BikeRepositry bikeRepositry = new BikeRepositry();

            var model = ridePersonRepositry.GetById(id);
            ViewBag.Bikes = bikeRepositry.GetByPersonId(id);

            return View(model);
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        public override ActionResult Edit(Person person)
        {
            try
            {
                RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
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
        public override ActionResult Delete(Int64 id)
        {
            RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
            var model = ridePersonRepositry.GetById(id);
            return View(model);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost]
        public override ActionResult Delete(Person person)
        {
            try
            {
                RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
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