using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.ViewModels
{
    public class BikeViewModel
    {
        public virtual Bike Bike { get; set; }
        public virtual SelectList Riders { get; set; }
    }
}