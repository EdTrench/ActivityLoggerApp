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
                    .ConnectionString(m => m.Server(@"f215daec-cb1e-4323-a8ac-a07400f27060.sqlserver.sequelizer.com")
                        .Database("dbf215daeccb1e4323a8aca07400f27060")
                        //.TrustedConnection()
                        .Username("gsohibevzlzdwyps")
                        .Password("43ccUr7HAUwCtxWuCNXEappz2rbfuRCVAZgS8rQ7TaYHNQFEMHLnhfRMMKjBq2nS")))
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