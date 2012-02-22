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
                case "Rider":
                    person = new RidePerson();
                    break;
                case "Runner":
                    person = new RunPerson();
                    break;
                case "Walker":
                    person = new WalkPerson();
                    break;
            }

            return person;
        }
    }
}