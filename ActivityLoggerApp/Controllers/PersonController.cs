using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Controllers;
using ActivityLoggerApp.Helpers;
using ActivityLoggerApp.ViewModels;
using ActivityLoggerApp.Repositories.Interfaces;

namespace ActivityLoggerApp.Controllers.Persons
{
    public class PersonController : Controller
    {
        IPersonRepository _PersonRepository;
        IBikeRepository _BikeRepository;

        public PersonController(IPersonRepository personRepository, IBikeRepository bikeRepository)
        {
            _PersonRepository = personRepository;
            _BikeRepository = bikeRepository;
        }
        
        //
        // GET: /Person/
        public ActionResult Index()
        {
            var id = HtmlExtensions.GetUserId();
            PersonRepository ridePersonRepositry = new PersonRepository();
            var model = ridePersonRepositry.GetByUserId(id);
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

            var viewModel = new PersonViewModel
            {
                Person = _PersonRepository.GetById(id)
            };

            viewModel.Bikes = new SelectList(_BikeRepository.GetByPersonId(id), "Id", "Name", viewModel.Person);

            return View(viewModel);
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        public  ActionResult Edit(PersonViewModel person)
        {
            try
            {
                PersonRepository ridePersonRepositry = new PersonRepository();
                ridePersonRepositry.Update(person.Person);
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