using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;
using System.Drawing;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Rooms
{
    internal class RoomModels : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.RoomModels; }
        }

        public void ParsePacket(Session session, Message message)
        {
            session.habboRoomObject = new Revision.R63B.Game.Rooms.Objects.Habbo.HabboRoomObject(session.Habbo.id, 1, new Point(session.X, session.Y));
            var Response = new Message(3076);
            Response.WriteString("xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxx0000x" + Convert.ToChar(13) + "xxxxxxx0000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "xx000000000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "");
            session.SendPacket(Response);

            Response = new Message(1065);
            Response.WriteString("xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxx0000x" + Convert.ToChar(13) + "xxxxxxx0000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "xx000000000x" + Convert.ToChar(13) + "xxx00000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "x0000000000x" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13) + "xxxxxxxxxxxx" + Convert.ToChar(13));
            session.SendPacket(Response);

            Response = new Message(2755);
            Response.WriteInt32(1);

            Response.WriteInt32(session.Habbo.id);
            Response.WriteString(session.Habbo.username);
            Response.WriteString(session.Habbo.motto);
            Response.WriteString(session.Habbo.figure);
            Response.WriteInt32(session.Habbo.id);
            Response.WriteInt32(2);
            Response.WriteInt32(5);
            Response.WriteString("0.0");
            Response.WriteInt32(2);
            Response.WriteInt32(1);
            Response.WriteString("m");
            Response.WriteInt32(-1);
            Response.WriteInt32(-1);
            Response.WriteInt32(0);
            Response.WriteInt32(1337);
            session.SendPacket(Response);

            Response = new Message(4038);
            Response.WriteBool(true);
            Response.WriteInt32(1); //RoomID
            Response.WriteBool(false);
            Response.WriteString("Best Room Ever");
            Response.WriteBool(true);
            Response.WriteInt32(1); //UID
            Response.WriteString(session.Habbo.username);
            Response.WriteInt32(0);
            Response.WriteInt32(25);
            Response.WriteInt32(25);
            Response.WriteString("desc");
            Response.WriteInt32(0);
            Response.WriteInt32(1);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteString(string.Empty);
            Response.WriteString(string.Empty);
            Response.WriteString(string.Empty);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteBool(true);
            Response.WriteBool(true);
            Response.WriteBool(false);
            session.SendPacket(Response);
        }

        #endregion
    }
}
