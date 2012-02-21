using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityLoggerApp.Models
{
    public class Login
    {
        public virtual Guid Id { get; set; }
        public virtual String Title { get; set; }
        public virtual String Forename { get; set; }
        public virtual String Surname { get; set; }
    }
}