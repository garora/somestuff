using CRUDWithWebAPI.Helper;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUDWithWebAPI.Models.Persistance
{
    public class ServerDataRepository : IServerDataRepository
    {
        public ServerDataRepository()
        {

        }

        public ServerData Get(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<ServerData>(id);
            }
        }

        public IEnumerable<ServerData> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<ServerData>().ToList();
            }
        }

        public ServerData Add(ServerData serverData)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(serverData);
                    transaction.Commit();
                }
                return serverData;
            }
        }

        public void Delete(int id)
        {
            var serverData = Get(id);

            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(serverData);
                    transaction.Commit();
                }
            }

        }

        public bool Update(ServerData serverData)
        {
            var isUpdated = false;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(serverData);
                    try
                    {
                        transaction.Commit();
                        isUpdated = true;
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                return isUpdated;
            }
        }
    }
}