using System;
using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.HandShake.Client
{
    internal class ClientSettings : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.ClientSettings; }
        }

        public void ParsePacket(Session session, Message message)
        {
            int id = message.NextInt32();
            var flashbase = message.NextString();
            var variables = message.NextString();

            //Console.WriteLine("Flashbase {0}, Variables {1} loaded.", flashbase, variables);

            /*Application.Application.Logging.WriteLine(string.Format("ID {0}", id));
            Application.Application.Logging.WriteLine(string.Format("Flashbase {0}", flashbase));
            Application.Application.Logging.WriteLine(string.Format("Variables {0}", variables));*/
        }

        #endregion
    }
}