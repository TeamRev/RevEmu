using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

using Revolution.Database.DAO.Repository;
using Revolution.Database.DAO.Repository.Interface;
using RevolutionDatabase.Tables;

namespace Revolution.Revision.R63.Game.Habbo.Friends.Controller
{
    class FriendController : IRepository<FriendController>
    {
        // Welcomes to Zak epics coding corner.

        private readonly int myId;

        private readonly int friendId;

        private readonly string accepted;

        public FriendController(int id)
        {
            usermessengerfriend friends;

            using (ISession session = Application.Application.DbManager.GetSessionFactory().OpenSession())
            {
                friends = session.Get<usermessengerfriend>(id);
                this.myId = friends.userId;
                this.friendId = friends.friendId;
                this.accepted = friends.accepted;
            }
        }

        public List<FriendController> GetMyFriends(int id)
        {
            // dumb pikkel.

            List<FriendController> storageCollection = new List<FriendController>();

            FriendController getData = new FriendController(id);


            // Should register all data
            storageCollection.Add(getData);


            return storageCollection;
        }

        public int Userid
        {
            get { return Userid; }
        }

        public int Getfriendid
        {
            get { return friendId; }
        }
        #region DAO
        public void SaveOrUpdate(FriendController instance)
        {
            new NHibernateRepository<FriendController>().SaveOrUpdate(instance);
        }

        public void Delete(FriendController instance)
        {
            new NHibernateRepository<FriendController>().Delete(instance);
        }


        #endregion
    }
}
