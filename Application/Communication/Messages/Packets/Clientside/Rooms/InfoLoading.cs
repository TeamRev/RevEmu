using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Rooms
{
    internal class InfoLoading : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.InfoLoading; }
        }

        public void ParsePacket(Session session, Message message)
        {
            /*
             * [LOG][CLIENT] > 2574: [0][0][0]D[10][0][0][0][1][0][0]^^[0]8b12104s05013s05014s05015b629b628442e26e378b9f8f18818bbaa
             * [LOG][CLIENT] > 3163: [0][0][0][6][12][[0][0][0][0]
             */

            var Response = new Message(2574);
            Response.WriteInt32(1);
            Response.WriteInt32(24158);
            Response.WriteString("b12104s05013s05014s05015b629b628442e26e378b9f8f18818bbaa");
            session.SendPacket(Response);

            Response = new Message(3163);
            Response.WriteInt32(0);
            session.SendPacket(Response);
        }

        #endregion
    }
}
