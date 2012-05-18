using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void Update(Person person);
        void Remove(Person person);
        Person GetById(Int64 id);
        List<Person> GetAll();
    }
}
