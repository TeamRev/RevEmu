using System;
using System.Linq;
using Mango.Communication.Sessions;
using Revolution.Application.HabboHotel.Rooms.Controllers;
using Revolution.Core;
using Revolution.Revision.R63B.Game.Rooms.Sql;

namespace Revolution.Messages.Packets
{
    internal class FeaturedRoom : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.FeaturedRooms; }
        }

        public void ParsePacket(Session session, Message message)
        {
        }

        #endregion
    }
}