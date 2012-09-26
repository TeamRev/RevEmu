using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Application.HabboHotel.Rooms.Controllers;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;
using Revolution.Revision.R63.Game.Habbo.Controller;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Navigator
{
    internal class OwnRooms : IPacketEvent
    {
        //[0][0][0]¢[0][0][0][5][0][0][0][0][0][1][3]£[0][0]mikkel328's  room[1][2]ÍÇæ[0][9]mikkel328[0]
        //[0][0][0][0][0][0][0][0][0][0][0]"mikkel328 has entered the building[0][0][0][0][0][0][0][0][0]
        //[0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][0][1][1][0]

        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.OwnRooms; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(3240);

            try
            {
                Response.WriteInt32(5);
                Response.WriteString("");
                Response.WriteInt32(1);

                Response.WriteInt32(1);
                Response.WriteBool(false);
                Response.WriteString("Best Room Ever");
                Response.WriteBool(true);
                Response.WriteInt32(session.Habbo.id);
                Response.WriteString(session.Habbo.username);
                Response.WriteInt32(int.Parse("0"));
                Response.WriteInt32(0);
                Response.WriteInt32(2500);
                Response.WriteString("Zak's gay.");
                Response.WriteInt32(0);
                //Response.WriteInt32((bool.Parse(room.allowWalkthrough)) ? 1 : 0);
                Response.WriteInt32(1);
                Response.WriteInt32(0);
                Response.WriteInt32(0);
                Response.WriteInt32(0); // No group id.
                Response.WriteString("");
                Response.WriteString("");
                Response.WriteString("");

                Response.WriteInt32(0);
                //for (int i = 0; i < room.tags.Count(); i++)
                //Response.WriteInt32(room.tags[i]);

                Response.WriteInt32(0);
                Response.WriteInt32(0);
                Response.WriteInt32(0);
                Response.WriteInt32(0);
                Response.WriteBool(true);
                Response.WriteBool(true);


                //foreach (RoomSql room in RoomSql.GetRooms(session.Habbo.id))
                //{
                    /*Response.WriteInt32(room.id);
                    Response.WriteBool(false);
                    Response.WriteString(room.caption);
                    Response.WriteBool(true);
                    Response.WriteInt32(session.Habbo.id);
                    Response.WriteString(session.Habbo.username);
                    Response.WriteInt32(int.Parse(room.state));
                    Response.WriteInt32(0);
                    Response.WriteInt32(room.usersMax);
                    Response.WriteString(room.description);
                    Response.WriteInt32(0);
                    //Response.WriteInt32((bool.Parse(room.allowWalkthrough)) ? 1 : 0);
                    Response.WriteInt32(1);
                    Response.WriteInt32(room.score);
                    Response.WriteInt32(room.category);
                    Response.WriteInt32(0); // No group id.
                    Response.WriteString("");
                    Response.WriteString("");
                    Response.WriteString("");

                    Response.WriteInt32(room.tags.Count());
                    //for (int i = 0; i < room.tags.Count(); i++)
                        //Response.WriteInt32(room.tags[i]);

                    Response.WriteInt32(0);
                    Response.WriteInt32(0);
                    Response.WriteInt32(0);
                    Response.WriteInt32(0);
                    Response.WriteBool(true);
                    Response.WriteBool(true);*/
                //}
                Response.WriteBool(false);
                session.SendPacket(Response);
            }

            catch (Exception e)
            {
                Console.WriteLine("Own Rooms Error: " + e);
            }
        }

        #endregion
    }
}
