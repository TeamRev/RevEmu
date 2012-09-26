using System;
using System.Threading.Tasks;
using NHibernate;
using Revolution.Api;
using Revolution.Database.DAO.Repository.Interface;


namespace Revolution.Database.DAO.Repository
{
    class NHibernateRepository<T> : IRepository<T>
    {
        public void SaveOrUpdate(T item)
        {
            using(var session = ApiRoot.DatabaseCallback.GetDatabase().GetSessionFactory().OpenSession())
            {
                session.SaveOrUpdate(item);
                session.Transaction.Commit();
            }
        }

        public void Delete(T item)
        {
            using (var session = ApiRoot.DatabaseCallback.GetDatabase().GetSessionFactory().OpenSession())
            {
                session.Delete(item);
                session.Transaction.Commit();
            }
        }
    }
}
