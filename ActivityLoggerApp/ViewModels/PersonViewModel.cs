using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.ViewModels
{
    public class PersonViewModel
    {
        public virtual Person Person { get; set; }
        public virtual SelectList Bikes { get; set; }
    }
}