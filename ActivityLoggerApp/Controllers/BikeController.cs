using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.ViewModels;
using ActivityLoggerApp.Repositories;


namespace ActivityLoggerApp.Controllers
{
    public class BikeController : Controller
    {
        //
        // GET: /Bike/

        public ActionResult Index()
        {
            BikeRepositry repositry = new BikeRepositry();
            var model = repositry.GetAll();
            return View(model);
        }

        //
        // GET: /Bike/Details/5

        public ActionResult Details(Int64 id)
        {
            BikeRepositry repositry = new BikeRepositry();
            var model = repositry.GetById(id);
            return View(model);
        }

        //
        // GET: /Bike/Create

        public ActionResult Create()
        {
            var model = new Bike();
            return View(model);
        } 

        //
        // POST: /Bike/Create

        [HttpPost]
        public ActionResult Create(Bike newBike)
        {
            try
            {
                BikeRepositry repositry = new BikeRepositry();
                repositry.Add(newBike);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Bike/Edit/5
 
        public ActionResult Edit(Int64 id)
        {
            BikeRepositry bikeRepositry = new BikeRepositry();
            PersonRepositry PersonRepositry = new PersonRepositry();

            var viewModel = new BikeViewModel
            {
                bike = bikeRepositry.GetById(id),
            };

            viewModel.riders = new SelectList(PersonRepositry.GetAll(), "Id", "Name", viewModel.bike.Person);

            return View(viewModel);
        }

        //
        // POST: /Bike/Edit/5
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Edit(BikeViewModel editBike)
        {
            try
            {
                BikeRepositry bikeRepositry = new BikeRepositry();
                PersonRepositry PersonRepositry = new PersonRepositry();

                editBike.bike.Person = PersonRepositry.GetById(editBike.bike.Person.Id);
                bikeRepositry.Update(editBike.bike);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Bike/Delete/5
 
        public ActionResult Delete(Int64 id)
        {
            BikeRepositry repositry = new BikeRepositry();
            var model = repositry.GetById(id);
            return View(model);
        }

        //
        // POST: /Bike/Delete/5

        [HttpPost]
        public ActionResult Delete(Bike removeBike)
        {
            try
            {
                BikeRepositry repositry = new BikeRepositry();
                repositry.Remove(removeBike); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
