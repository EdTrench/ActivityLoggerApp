using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Models
{
    public class Bike
    {
        public virtual Int64 Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
    }

}