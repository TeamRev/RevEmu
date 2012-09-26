using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;
using Revolution.Revision.R63B.Game.Rooms.Sql;

namespace Revolution.Revision.R63B.Game.Rooms.Packet
{
    internal class WalkEvent : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.Walk; }
        }

        public void ParsePacket(Session session, Message Message)
        {
            new RoomModelSql().CreateIntsance(session.Habbo.id).Walk(session, Message);
        }

        #endregion
    }
}