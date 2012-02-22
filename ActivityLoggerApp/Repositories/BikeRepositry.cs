using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;
using NHibernate;
using NHibernate.Linq;

namespace ActivityLoggerApp.Repositories
{
    public class BikeRepositry : IBikeRepositry
    {
        public void Add(Bike bike)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(bike);
                    transaction.Commit();
                }
        }

        public IList<Bike> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from bike in session.Query<Bike>()
                            select bike;
                return (query).ToList();
            }
        }

        public Bike GetById(Int64 id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from bike in session.Query<Bike>()
                            where bike.Id == id
                            select bike;
                return query.Single();
            }
        }

        public IList<Bike> GetByPersonId(Int64 riderId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from bike in session.Query<Bike>()
                            where bike.RidePerson.Id == riderId
                            select bike;
                return (query).ToList();
            }
        }

        public void Remove(Bike bike)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(bike);
                    transaction.Commit();
                }
        }

        public void Update(Bike bike)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                using(ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(bike);
                    transaction.Commit();
                }
        }
    }
}