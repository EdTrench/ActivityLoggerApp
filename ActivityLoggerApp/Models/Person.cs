using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityLoggerApp.Models
{
    public class Person
    {
        public virtual Int64 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual Int16 Weight { get; set; }
        public virtual DateTime Dob { get; set; }
        public virtual IList<Bike> Bikes { get; set; }
        public virtual Int16 Category { get; set; }
    }
}