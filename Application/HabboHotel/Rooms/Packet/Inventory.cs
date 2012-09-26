using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Revision.R63B.Game.Rooms.Packet
{
    internal class Inventory : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.Inventory; }
        }

        public void ParsePacket(Session session, Message Message)
        {
            //Message Response = new Message();
        }

        #endregion
    }
}