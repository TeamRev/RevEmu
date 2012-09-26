using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.HandShake.UserInfo
{
    internal class ClubVIP : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.ClubVIP; }
        }

        public void ParsePacket(Session session, Message Message)
        {
            var Response = new Message(SendHeaders.InitClubStatus);
            Response.WriteString(Message.NextString());
            Response.WriteInt32(10);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(1);
            Response.WriteBool(false);
            Response.WriteBool(true);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            session.SendPacket(Response);
        }

        #endregion
    }
}