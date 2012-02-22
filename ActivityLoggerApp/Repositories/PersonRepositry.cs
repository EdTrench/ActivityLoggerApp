using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;
using NHibernate;
using NHibernate.Linq;

namespace ActivityLoggerApp.Repositories
{
    public abstract class PersonRepositry : IPersonRepositry
    {
        public abstract void Add(Person person);
        public abstract List<Person> GetAll();
        public abstract Person GetById(Int64 id);
        public abstract void Remove(Person person);
        public abstract void Update(Person person);
    }
}