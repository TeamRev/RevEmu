using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Messenger
{
    internal class SearchResultAdd : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SearchResultAdd; // Dunno.
            }
        }

        public void ParsePacket(Session session, Message message)
        {
            message = new Message(2403);

            message.WriteInt32(6);
        }

        #endregion
    }
}