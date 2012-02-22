using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Controllers
{
    public abstract class PersonController : Controller
    {
        //
        // GET: /Person/
        public abstract ActionResult Index();
        //
        // GET: /Person/Details/5
        public abstract ActionResult Details(Int64 id);
        //
        // GET: /Person/Create
        public abstract ActionResult Create();
        //
        // POST: /Person/Create
        [HttpPost]
        public abstract ActionResult Create(Person person);        
        //
        // GET: /Person/Edit/5
        public abstract ActionResult Edit(Int64 id);
        //
        // POST: /Person/Edit/5
        [HttpPost]
        public abstract ActionResult Edit(Person person);
        //
        // GET: /Person/Delete/5
        public abstract ActionResult Delete(Int64 id);
        //
        // POST: /Person/Delete/5
        [HttpPost]
        public abstract ActionResult Delete(Person person);
    }
}