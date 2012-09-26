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
    internal class ShoutOnHotel : IPacketEvent
    {
        #region PacketEvent Members

        /// <summary>
        /// Event id for current Packet
        /// </summary>
        public uint EventId
        {
            get { return RevcHeaders.ShoutOnHotel; }
        }

        /// <summary>
        /// Handles Packet, for current user, and message event.
        /// </summary>
        /// <param name="Session">User of Packet</param>
        /// <param name="Message">Message for User</param>
        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(3298);
            Response.WriteInt32(session.Habbo.id);
            Response.WriteString(message.NextString());
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(-1);
            session.SendPacket(Response);
        }

        #endregion
    }
}
