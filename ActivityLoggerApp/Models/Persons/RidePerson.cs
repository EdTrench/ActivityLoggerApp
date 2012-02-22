using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityLoggerApp.Models.Persons
{
    public enum Category {First, Second, Third, Forth}
    
    public class RidePerson : Person
    {
        public virtual IList<Bike> Bikes { get; set; }
        public virtual Category Category { get; set; }
    }
}