using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models.Interfaces;

namespace ActivityLoggerApp.Models
{
    public abstract class Activity
    {
        public virtual Int64 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual DateTime Start { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual Double Distance { get; set; }
        public virtual String Description { get; set; }
    }
}