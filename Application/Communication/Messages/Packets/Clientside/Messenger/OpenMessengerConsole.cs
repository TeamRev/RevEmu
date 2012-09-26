using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Messenger
{
    internal class OpenMessengerConsole : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.OpenMessengerConsole; }
        }

        public void ParsePacket(Session session, Message message)
        {
        }

        #endregion
    }
}