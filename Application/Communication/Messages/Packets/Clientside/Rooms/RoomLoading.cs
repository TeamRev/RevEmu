using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Rooms
{
    /// <summary>
    /// Loads user in room.
    /// </summary>
    internal class RoomLoading : IPacketEvent
    {
        #region PacketEvent Members

        /// <summary>
        /// Event id for current Packet
        /// </summary>
        public uint EventId
        {
            get { return RevcHeaders.RoomLoading; }
        }

        /// <summary>
        /// Handles Packet, for current user, and message event.
        /// </summary>
        /// <param name="gameclient">User of Packet</param>
        /// <param name="Message">Message for User</param>
        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(2121);
            session.SendPacket(Response);

            Response = new Message(294);
            Response.WriteString("model_f"); // Room Model
            Response.WriteInt32(1); // id ?
            session.SendPacket(Response);

            Response = new Message(3248);
            Response.WriteString("floor");
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(3248);
            Response.WriteString("landscape");
            Response.WriteString("0.0");
            session.SendPacket(Response);

            Response = new Message(3323);
            Response.WriteInt32(4);
            session.SendPacket(Response);

            Response = new Message(3840);
            session.SendPacket(Response);

            Response = new Message(1794);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(369);
            Response.WriteInt32(142641);
            session.SendPacket(Response);
        }

        #endregion
    }

}
