using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models;
using NHibernate;
using NHibernate.Linq;

namespace ActivityLoggerApp.Repositories
{
    public class LoginRepositry : ILoginRepositry
    {
        public void Add(Login login)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(login);
                transaction.Commit();
            }
        }

        public List<Login> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from bike in session.Query<Login>()
                            select bike;
                return (query).ToList();
            }
        }

        public Login GetById(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from login in session.Query<Login>()
                            where login.Id == id
                            select login;
                return query.Single();
            }
        }

        public void Remove(Login login)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(login);
                transaction.Commit();
            }
        }

        public void Update(Login login)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(login);
                transaction.Commit();
            }
        }
    }
}