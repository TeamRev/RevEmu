using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;

namespace Revolution.Application.Communication.Messages.Packet_Structure
{
    interface IMessageEvent
    {
        /// <summary>
        /// Handles the incoming packet.
        /// </summary>
        /// <param name="Session">Session to use</param>
        /// <param name="Packet">Message builded in packet.</param>
        void Invoke(Session Session, Message Packet);
    }
}
