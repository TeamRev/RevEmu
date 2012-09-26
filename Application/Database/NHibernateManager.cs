using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

using Revolution.Revision.R63.Game.Habbo.Controller;
using RevolutionDatabase.Tables;


namespace Revolution.Database
{
    internal class NHibernateManager
    {
        private readonly ISessionFactory _dbSessionFactory;

        public NHibernateManager(string connstring)
        {
            _dbSessionFactory = CreateSessionFactory(connstring);
        }

        private ISessionFactory CreateSessionFactory(string connstring)
        {
            return Fluently.Configure()
                      .Database(MySQLConfiguration.Standard.ConnectionString(connstring))
                      .Cache(c => c.UseQueryCache().UseSecondLevelCache().UseMinimalPuts())
                      .Mappings(m => m.FluentMappings.Add<userMap>())
                      .Mappings(m => m.FluentMappings.Add<catalogpageMap>())
                      .BuildSessionFactory();
        }

        public ISessionFactory GetSessionFactory()
        {
            return _dbSessionFactory;
        }
    }
}