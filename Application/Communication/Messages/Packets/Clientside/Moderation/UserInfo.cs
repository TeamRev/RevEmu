using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Moderation
{
    internal class UserInfo : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.ModerationUserInformation; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var Uinfo = new Message(3744);
            Uinfo.WriteInt32(session.Habbo.id); // id perhaps
            Uinfo.WriteString(session.Habbo.username); // names
            Uinfo.WriteInt32(4); // registered minutes ago
            Uinfo.WriteInt32(8); // last login minutes ago
            Uinfo.WriteBool(true); // is online, NO doubt
            Uinfo.WriteInt32(1); // cfhs
            Uinfo.WriteInt32(2); // abusive cfhs
            Uinfo.WriteInt32(3); // cautions
            Uinfo.WriteInt32(4); // bans
            Uinfo.WriteString("3"); // purchase shit?
            Uinfo.WriteInt32(3); // no idea yet
            Uinfo.WriteInt32(5); // amount banned accounts lol
            Uinfo.WriteString("666"); // some shit above banned accounts
            session.SendPacket(Uinfo);
        }

        #endregion
    }
}