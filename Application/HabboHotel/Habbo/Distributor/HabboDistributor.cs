using NHibernate.Criterion;
using Revolution.Util.External.Nito.Cache;
using Revolution.Revision.R63.Game.Habbo.Controller;

using Revolution.Api;
using RevolutionDatabase.Tables;

namespace Revolution.Application.HabboHotel.Habbo.Distributor
{
    /// <summary>
    // IHI Class used for Rev. Added license above. All credits to Cecer1
    /// </summary>
    class HabboDistributor
    {

        #region Fields
        #region Field: _idCache
        private readonly WeakCache<int, HabboController> _idCache;
        #endregion
        #region Field: _usernameCache
        private readonly WeakCache<string, HabboController> _usernameCache;
        #endregion
        #endregion

        #region Indexers
        #region Indexer: int
        public HabboController this[int id]
        {
            get
            {
                HabboController result = _idCache[id];
                _usernameCache[result.username] = result;
                return result;
            }
        }
        #endregion
        #region Indexer: string
        public HabboController this[string username]
        {
            get
            {
                HabboController result = _usernameCache[username];
                _idCache[result.id] = result;
                return result;
            }
        }
        #endregion
        #endregion

        #region Methods
        #region Method: HabboDistributor (Construct
        public HabboDistributor()
        {
            _idCache = new WeakCache<int, HabboController>(CacheInstanceGenerator);
            _usernameCache = new WeakCache<string, HabboController>(CacheInstanceGenerator);
        }
        #endregion

        #region Method: GetHabbo
        public HabboController GetHabbo(string ssoTicket)
        {
            using (var dbSession = ApiRoot.DatabaseCallback.GetDatabase().GetSessionFactory().OpenSession())
            {
                var p = dbSession.CreateCriteria<user>().Add(Restrictions.Eq("ticket", ssoTicket)).UniqueResult<user>();

               if (p.id == 0)
                   return null;

               return this[p.id];
            }
        }
        #endregion

        #region Method: CleanUp
        /// <summary>
        ///   Remove any collected Habbos from the cache.
        /// </summary>
        private void CleanUp()
        {
            _idCache.CleanUp();
            _usernameCache.CleanUp();
        }
        #endregion

        #region Method: CacheInstanceGenerator
        public HabboController CacheInstanceGenerator(int id)
        {
            return new HabboController(id);
        }
        public HabboController CacheInstanceGenerator(string username)
        {
            return new HabboController(username);
        }
        #endregion
        #endregion
    }
}