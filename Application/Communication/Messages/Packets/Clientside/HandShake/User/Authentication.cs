using Mango.Communication.Sessions;
using Revolution.Application.HabboHotel.Habbo.Distributor;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;
using Revolution.Revision.R63B.Game;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.HandShake.User
{
    internal class Authentication : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SSOTicket; }
        }

        public void ParsePacket(Session session, Message message)
        {
            string sso = message.NextString();
            //Application.Logging.WriteLine(string.Format("SSO Ticket: {0}", sso));

            var loadMyHabbo = new HabboDistributor().GetHabbo(sso);

            session.Habbo = loadMyHabbo;
            
            var response = new Message(SendHeaders.InitHotelView);
            session.SendPacket(response);
        }

        #endregion
    }
}