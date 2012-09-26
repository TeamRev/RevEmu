using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Groups
{
    internal class GroupMembers : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.GroupMembers; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var response = new Message(1263);
            response.WriteInt32(326494);
            response.WriteString("[Âµ] Train Station [Âµ] NYC [Âµ]");
            response.WriteInt32(55701607);
            response.WriteString("b22234s9723416fe55795537635b44781e732427990d");
            response.WriteInt32(14);
            response.WriteInt32(1);
            response.WriteInt32(0);
            response.WriteInt32(1);
            response.WriteString("JakeSS");
            response.WriteString(
                "hr-3163-61.hd-3091-6.ch-255-64.lg-3023-110.sh-3068-64-64.ha-1022-110.ea-3226-110.fa-1205-110.ca-3176-93-93.cc-3075-110.cp-3204");
            response.WriteString("Mar 17, 2012");

            response.WriteInt32(0);
            response.WriteInt32(0);
            response.WriteString(string.Empty);
            session.SendPacket(response);
        }

        #endregion
    }
}