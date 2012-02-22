using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Repositories;
using ActivityLoggerApp.Models;
using NHibernate;
using NHibernate.Linq;
using ActivityLoggerApp.Models.Persons;

namespace ActivityLoggerApp.Repositories.Persons
{
    public class RidePersonRepositry : PersonRepositry
    {
        public override void Add(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }

        public override List<Person> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from rider in session.Query<Person>()
                            select rider;
                return (query).ToList();
            }
        }

        public override Person GetById(Int64 id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from ridePerson in session.Query<RidePerson>()
                            where ridePerson.Id == id
                            select ridePerson;
                return query.Single();
            }
        }

        public override void Remove(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(person);
                transaction.Commit();
            }
        }

        public override void Update(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(person);
                transaction.Commit();
            }
        }
    }
}