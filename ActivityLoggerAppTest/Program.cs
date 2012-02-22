using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Models.Factories;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Repositories.Persons;

namespace ActivityLoggerAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonFactory pf = new PersonFactory();
            //Person walker = pf.CreatePerson("Walker");

            //Person rider = pf.CreatePerson("Rider");

            RidePersonRepositry ridePersonRepositry = new RidePersonRepositry();
            var model = ridePersonRepositry.GetById(1);


        }
    }
}
