using System;
using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.HandShake.Client
{
    internal class PressedButton : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.Ping; }
        }

        public void ParsePacket(Session session, Message message)
        {
            Console.WriteLine("> " + message.NextString() + " > " + message.NextString() + " > " + message.NextString() +
                              " > " + message.NextInt32());
        }

        #endregion
    }
}