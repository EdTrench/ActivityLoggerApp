using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using ActivityLoggerApp.Models;


namespace ActivityLoggerApp.Repositories
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    Bike bike = new Bike();
                    Configuration configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Bike).Assembly);
                    //new SchemaExport(configuration).Execute(true, false, false);
                    _sessionFactory = configuration.BuildSessionFactory();
                 }

                return _sessionFactory;
            }
            
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        
    }
}