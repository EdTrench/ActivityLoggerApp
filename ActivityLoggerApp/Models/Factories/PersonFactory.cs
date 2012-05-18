using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models.Interfaces;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Models.Factories
{
    public class PersonFactory : IPerson
    {
        Person person;

        public Person CreatePerson(String personType)
        {
            return person = new Person();
        }
    }
}