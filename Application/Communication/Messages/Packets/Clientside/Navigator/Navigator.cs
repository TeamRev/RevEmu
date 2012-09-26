using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Navigator
{
    class Navigator : IPacketEvent
    {
        public uint EventId
        {
            get { return RevcHeaders.NavigatorInit; }
        }

        public void ParsePacket(Session session, Message message)
        {
            
        }
    }
}
