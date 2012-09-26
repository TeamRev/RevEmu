using System.Collections.Generic;
using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Messenger
{
    internal class OpenMessenger : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.OpenMessenger; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(SendHeaders.FriendBarInit);

        }

        #endregion
    }
}