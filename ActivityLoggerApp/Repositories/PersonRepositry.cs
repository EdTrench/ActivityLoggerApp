using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;
using NHibernate;
using NHibernate.Linq;

namespace ActivityLoggerApp.Repositories
{
    public class PersonRepositry : IPersonRepositry
    {
        public void Add(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }

        public List<Person> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from rider in session.Query<Person>()
                            select rider;
                return (query).ToList();
            }
        }

        public Person GetById(Int64 id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from person in session.Query<Person>()
                            where person.Id == id
                            select person;
                return query.Single();
            }
        }

        public void Remove(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(person);
                transaction.Commit();
            }
        }

        public void Update(Person person)
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