using System;
using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Messenger
{
    internal class SendMessage : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SendConsoleMessage; }
        }

        public void ParsePacket(Session session, Message message)
        {
            int FriendId = message.NextInt32();

            string theMessage = message.NextString();

            Console.WriteLine(FriendId);
            var Response = new Message(2582);
            Response.WriteInt32(FriendId);
            Response.WriteString(theMessage);
            Response.WriteString(string.Empty);
            session.SendPacket(Response);
        }

        #endregion
    }
}