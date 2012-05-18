using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.ViewModels;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Repositories.Interfaces;
using Microsoft.Practices.Unity;
using ActivityLoggerApp.Helpers;

namespace ActivityLoggerApp.Controllers
{
    public class BikeController : Controller
    {
        IBikeRepository _BikeRepository;
        IPersonRepository _PersonRepository;

        public BikeController(IBikeRepository bikeRepository, IPersonRepository personRepository)
        {
            _BikeRepository = bikeRepository;
            _PersonRepository = personRepository;
        }
        
        //
        // GET: /Bike/
        public ActionResult Index()
        {
            var model = _BikeRepository.GetAll();
            return View(model);
        }

        //
        // GET: /Bike/Details/5

        public ActionResult Details(Int64 id)
        {
            var model = _BikeRepository.GetById(id);
            return View(model);
        }

        //
        // GET: /Bike/Create

        public ActionResult Create()
        {
            var viewModel = new BikeViewModel();
            viewModel.Persons = new SelectList(_PersonRepository.GetAll(), "Id", "Name");
            viewModel.BikeTypes = Enumerable.Range(0, Enum.GetValues(typeof(ActivityLoggerApp.Helpers.Enums.BikeType)).Length).Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = ModelExtensions.ToFriendlyString((ActivityLoggerApp.Helpers.Enums.BikeType)x)
            });

            return View(viewModel);
        } 

        //
        // POST: /Bike/Create

        [HttpPost]
        public ActionResult Create(BikeViewModel newBike)
        {
            try
            {
                _BikeRepository.Add(newBike.Bike);
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
            var viewModel = new BikeViewModel
            {
                Bike = _BikeRepository.GetById(id),
            };

            viewModel.Persons = new SelectList(_PersonRepository.GetAll(), "Id", "Name", viewModel.Bike.Person);
            viewModel.BikeTypes = Enumerable.Range(0, Enum.GetValues(typeof(ActivityLoggerApp.Helpers.Enums.BikeType)).Length).Select(x => new SelectListItem
            {
                Selected = x.Equals((int)viewModel.Bike.Type),
                Value = x.ToString(),
                Text = ModelExtensions.ToFriendlyString((ActivityLoggerApp.Helpers.Enums.BikeType)x)
            });


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
                _BikeRepository.Update(editBike.Bike);
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
            var model = _BikeRepository.GetById(id);
            return View(model);
        }

        //
        // POST: /Bike/Delete/5

        [HttpPost]
        public ActionResult Delete(Bike removeBike)
        {
            try
            {
                _BikeRepository.Remove(removeBike); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
