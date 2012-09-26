using NHibernate;
using Revolution.Core;
using NHibernate.Criterion;

using Revolution.Database.DAO.Repository;
using Revolution.Database.DAO.Repository.Interface;
using RevolutionDatabase.Tables;

namespace Revolution.Revision.R63.Game.Habbo.Controller
{
    /// <summary>
    /// HabboController controls all the data for the entity "habbo"
    /// </summary>
    public class HabboController : IRepository<HabboController>
    {
        #region Fields
        public int id { get; set; }

        public int habboId { get; set; }

        public string username { get; set; }

        public string motto { get; set; }

        public string figure { get; set; }

        public int credits { get; set; }

        public string gender { get; set; }

        public int? homeRoom { get; set; }

        public string online { get; set; }

        public int rank { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public double Z;
        #endregion

        #region Data Object Access Methods

        /* All methods are using Async within the background */

        #region Method: SaveOrUpddate
        public void SaveOrUpdate(HabboController instance)
        {
            new NHibernateRepository<HabboController>().SaveOrUpdate(instance);
        }
        #endregion

        #region Method: Delete
        public void Delete(HabboController instance)
        {
            new NHibernateRepository<HabboController>().Delete(instance);
        }

        #endregion

        #region Method: GetData
        public HabboController(int id)
        {
            user habboData;

            using (ISession sess = Application.Application.DbManager.GetSessionFactory().OpenSession())
            {
                habboData = sess.Get<user>(id);
                this.id = habboData.id;
                this.habboId = id;
                this.username = habboData.username;
                this.motto = habboData.motto;
                this.figure = habboData.figure;
                this.credits = habboData.credits;
                this.gender = habboData.gender;
                this.homeRoom = habboData.homeRoom;
                this.online = habboData.online;
                this.rank = habboData.rank;
                this.X = 3;
                this.Y = 5;
                this.Z = 0;
            }
        }

        public HabboController(string username)
        {
            user habboData;

            using (ISession sess = Application.Application.DbManager.GetSessionFactory().OpenSession())
            {
                habboData = sess.CreateCriteria<user>().Add(Restrictions.Eq("username", username)).UniqueResult<user>();
                this.id = habboData.id;
                this.habboId = id;
                this.username = habboData.username;
                this.motto = habboData.motto;
                this.figure = habboData.figure;
                this.credits = habboData.credits;
                this.gender = habboData.gender;
                this.homeRoom = habboData.homeRoom;
                this.online = habboData.online;
                this.rank = habboData.rank;
            }
        }

        #endregion

        

        /* End of methods that are linked to the Data Object Access module */
        #endregion
    }
}
