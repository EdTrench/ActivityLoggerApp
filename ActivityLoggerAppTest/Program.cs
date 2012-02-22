using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Models.Factories;
using ActivityLoggerApp.Repositories;

namespace ActivityLoggerAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonFactory pf = new PersonFactory();
            //Person walker = pf.CreatePerson("Walker");

            //Person rider = pf.CreatePerson("Rider");

            PersonRepositry PersonRepositry = new PersonRepositry();
            var model = PersonRepositry.GetById(1);


        }
    }
}
