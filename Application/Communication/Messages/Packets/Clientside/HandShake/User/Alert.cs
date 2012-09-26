using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.HandShake.User
{
    internal class Alert : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.Alert; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var response = new Message(544);
            response.WriteString("Team Rev|");
            response.WriteString("");
            session.SendPacket(response);
        }

        #endregion
    }
}