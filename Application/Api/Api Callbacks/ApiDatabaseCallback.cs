using Revolution.Api.Api_Enumerables;
using Revolution.Api.Api_Interface;
using Revolution.Database;
using Revolution.Revision;

namespace Revolution.Api.Api_Callbacks
{
    class ApiDatabaseCallback : IApiable
    {
        /// <summary>
        /// Gets the Database Manager, creates a new instance using the Connection string from the Environnent
        /// </summary>
        private static NHibernateManager DbManager
        {
            get { return new NHibernateManager(Application.Application.ConnectionString); }
        }

        /// <summary>
        /// Gives the API Caller, a new callback with a fresh new instance of the NHibernate Manager
        /// </summary>
        /// <returns>New instance of NHibernateManager</returns>
        public NHibernateManager GetDatabase()
        {
            return DbManager;
        }

        public string ApiName
        {
            get { return "DatabaseManager"; }
        }

        public ApiPermissionEnumerable Priority
        {
            get { return ApiPermissionEnumerable.Needed; }
        }
    }
}
