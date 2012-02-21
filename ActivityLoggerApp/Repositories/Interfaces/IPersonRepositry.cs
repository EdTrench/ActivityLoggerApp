using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Models
{
    interface IPersonRepositry
    {
        void Add(Person person);
        void Update(Person person);
        void Remove(Person person);
        Person GetById(Int64 id);
        List<Person> GetAll();
    }
}
