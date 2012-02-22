using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models.Interfaces;
using ActivityLoggerApp.Models.Persons;

namespace ActivityLoggerApp.Models.Factories
{
    public class PersonFactory : IPerson
    {
        Person person;

        public Person CreatePerson(String personType)
        {
            switch (personType)
            {
                case "Ride":
                    person = new RidePerson();
                    break;
                case "Run":
                    person = new RunPerson();
                    break;
                case "Walk":
                    person = new WalkPerson();
                    break;
            }

            return person;
        }
    }
}