using System;
using Mango.Communication.Sessions;
using Revolution.Core;


namespace Revolution.Messages.Packets.Messenger
{
    internal class SearchFriend : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SearchFriend; // Get Id for this.
            }
        }

        public void ParsePacket(Session session, Message message)
        {
            message = new Message(619);

            message.WriteInt32(0);
            message.WriteInt32(1);
            int id = message.NextInt32(); // UserId?
            Console.WriteLine(id);

            //var result = new HabboSqlData(id);

           // message.WriteString(result.username);
            message.WriteBool(false);
            //message.WriteString(result.motto);
            message.WriteInt32(0);
            message.WriteInt32(1);
            message.WriteInt32(0);
        }

        #endregion
    }
}