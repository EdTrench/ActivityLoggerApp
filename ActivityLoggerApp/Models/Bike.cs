using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityLoggerApp.Models

{
    public class Bike
    {
        public virtual Int64 Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual String Name { get; set; }
        public virtual ActivityLoggerApp.Helpers.Enums.BikeType Type { get; set; }
    }
}