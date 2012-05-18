using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using ActivityLoggerApp.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;

namespace ActivityLoggerApp.Repositories
{
    public class NHibernateHelper
    {

        //private static ISessionFactory _sessionFactory;
        
        private static ISessionFactory SessionFactory
        {
            get
            {
                return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(m => m.Server(@".\SQLEXPRESS")
                        .Database("CycleLoggerDb")
                        .TrustedConnection()))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                    //.ExposeConfiguration(ExportSchema)
                .BuildSessionFactory();


                //if (_sessionFactory == null)
                //{
                //    Bike bike = new Bike();
                //    Configuration configuration = new Configuration();
                //    configuration.Configure();
                    
                //    //configuration.Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));
                    
                //    configuration.AddAssembly(typeof(Bike).Assembly);
                //    //new SchemaExport(configuration).Execute(true, false, false);
                    
                //    _sessionFactory = configuration.BuildSessionFactory();
                // }
                //return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        
    }
}