using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.Navigator
{
    class PublicRooms : IPacketEvent
    {
        public uint EventId
        {
            get { return 4009; }
        }

        public void ParsePacket(Session session, Message message)
        {
            
        }
    }
}
