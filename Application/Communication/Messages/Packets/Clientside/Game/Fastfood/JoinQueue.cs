using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Game.Fastfood
{
    internal class JoinQueue : IPacketEvent
    {
        public uint EventId
        {
            get { return RevcHeaders.JoinQueue; }
        }

        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(2888);
            Response.WriteInt32(3);
            session.SendPacket(Response);

            Response = new Message(1401);
            Response.WriteInt32(3);
            Response.WriteString("1344031458870");
            Response.WriteString("http://habbo.hs.llnwd.net/basejump/693/BaseJump.swf");
            Response.WriteString("best");
            Response.WriteString("showAll");
            Response.WriteInt32(60);
            Response.WriteInt32(10);
            Response.WriteInt32(0);
            Response.WriteInt32(4);
            Response.WriteString("accessToken");
            Response.WriteString(session.Habbo.username + "-" + session.Habbo.figure);
            Response.WriteString("gameServerHost");
            Response.WriteString("ff-am.habbo.com");
            Response.WriteString("gameServerPort");
            Response.WriteString("30000");
            Response.WriteString("socketPolicyPort");
            Response.WriteString("30843");
            session.SendPacket(Response);
        }
    }
}
