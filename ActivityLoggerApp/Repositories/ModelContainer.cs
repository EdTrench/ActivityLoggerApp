using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using ActivityLoggerApp.Repositories.Interfaces;

namespace ActivityLoggerApp.Repositories
{
    public static class ModelContainer
    {
        private static readonly object key = new object();
        private static IUnityContainer instance;

        static ModelContainer()
        {
            instance = new UnityContainer();
        }

        public static IUnityContainer Instance
        {
            get
            {
               instance = new UnityContainer();
               instance.RegisterType<IBikeRepository, BikeRepositry>();
               instance.RegisterType<IPersonRepository, PersonRepository>();
               return instance;
            }
        }
    }
}