using System;
using System.Collections.Generic;
using Mango.Communication.Sessions;
using Revolution.Core;


namespace Revolution.Messages.Packets.Messenger
{
    internal class AcceptFriendRequest : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get
            {
                return RevcHeaders.AcceptFriendRequest; // Don't know id.
            }
        }


        public void ParsePacket(Session session, Message message)
        {
            // This is totally wrong, needs to be redone

            int targetId = message.NextInt32();


        }
        #endregion
    }
}