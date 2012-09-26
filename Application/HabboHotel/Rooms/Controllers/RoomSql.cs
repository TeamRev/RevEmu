using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Revolution.Application.HabboHotel.Habbo.Distributor;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Revision.R63B.Game;

namespace Revolution.Application.HabboHotel.Rooms.Controllers
{
    internal class RoomSql
    {
        #region #NHibenate Columns#

        public static IList<RoomSql> AllRooms = new List<RoomSql>();
        public int id;
        public int ownerId;
        public string caption;
        public string description;
        public string model;
        public string state;
        public int category;
        public string password;
        public string wallpaper;
        public int wallsize;
        public string floor;
        public int floorsize;
        public int score;
        public List<string> tags;
        public int iconbg;
        public int iconfg;
        public List<string> iconitems;
        public int usersMax;
        public int usersNow;

        #endregion

        public int GetUsersInRoom
        {
            get { return usersNow; }
        }

        /// <summary>
        /// Load's room data by RoomId
        /// </summary>
        /// <param name="id">RoomId</param>
        public static List<RoomSql> GetData()
        {
            // Uses MySql Reader, since i had problems with NHibernate doing this.

            var room = new List<RoomSql>();

            MySqlDataReader reader = MySqlHelper.ExecuteReader(Application.ConnectionString, "SELECT * FROM rooms");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var instance = new RoomSql();
                    instance.id = reader.GetInt32("id");
                    instance.ownerId = reader.GetInt32("owner_id");
                    instance.caption = reader.GetString("name");
                    instance.description = reader.GetString("description");
                    instance.model = reader.GetString("model");
                    instance.state = reader.GetString("state");
                    instance.category = reader.GetInt32("category");
                    instance.password = reader.GetString("password");
                    instance.wallpaper = reader.GetString("wallpaper");
                    instance.wallsize = reader.GetInt32("wallsize");
                    instance.floor = reader.GetString("floor");
                    instance.floorsize = reader.GetInt32("floorsize");
                    instance.score = reader.GetInt32("score");
                    instance.tags.Add(reader.GetString("tags"));
                    instance.iconbg = reader.GetInt32("iconbg");
                    instance.iconfg = reader.GetInt32("iconfg");
                    instance.iconitems.Add(reader.GetString("iconitems"));
                    instance.usersMax = reader.GetInt32("users_max");
                    instance.usersNow = reader.GetInt32("users_now");

                    AllRooms.Add(instance);
                }
            }

            return room;
        }

        public static IList<RoomSql> GetRooms(int ownerId)
        {
            var mRooms = new List<RoomSql>();

            for (int i = 0; i < AllRooms.Count; i++)
            {
                var controller = new HabboController(AllRooms[i].ownerId);
                if (new HabboDistributor().GetHabbo(controller.username).id != ownerId)
                    continue;

                mRooms.Add(AllRooms[i]);
            }
            return mRooms;
        }
    }
}