using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Models.Persons;

namespace ActivityLoggerApp.Models

{
    public enum Type {Road, Mountain, Track, Tourer, CycloCross, TimeTrail, BMX}

    public class Bike
    {
        public virtual Int64 Id { get; set; }
        public virtual RidePerson RidePerson { get; set; }
        public virtual String Name { get; set; }
        public virtual Type Type { get; set; }
    }
}