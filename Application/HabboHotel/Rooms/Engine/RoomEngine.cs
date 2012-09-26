using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Revolution.Application.HabboHotel.Habbo.Distributor;
using Revolution.Application.HabboHotel.Rooms.Controllers;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Revision.R63B.Game.Rooms.Sql;

namespace Revolution.Revision.R63B.Game.Rooms.Engine
{
    internal class RoomEngine
    {
        private static readonly ConcurrentQueue<RoomSql> Rooms = new ConcurrentQueue<RoomSql>();

        public static ConcurrentQueue<RoomSql> AllRooms()
        {
            return Rooms;
        }

        public static List<RoomSql> GetRoomByOwner(int ownerId)
        {
            var rooms = new List<RoomSql>();

            foreach (RoomSql sql in AllRooms())
            {
                var controller = new HabboController(sql.ownerId);
                if (new HabboDistributor().GetHabbo(controller.username).id == ownerId)
                {
                    rooms.Add(sql);
                }
            }

            return rooms;
        }

        public static RoomSql GetRoomById(int roomId)
        {
            foreach (RoomSql sql in AllRooms())
            {
                if (sql.id == roomId)
                {
                    return sql;
                }
            }

            // Result found.
            return null;
        }

        public static void RemoveRoomByOwnerId(int ownerId)
        {
            foreach (RoomSql sql in Rooms)
            {
                if (sql.id == ownerId)
                {
                    Rooms.ToList().Remove(sql);
                }
            }
        }

        public static void RemoveRoomByRoomId(int roomId)
        {
            foreach (RoomSql sql in Rooms)
            {
                if (sql.id == roomId)
                {
                    Rooms.ToList().Remove(sql);
                }
            }
        }
    }
}