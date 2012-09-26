using System;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.HandShake.Encryption
{
    internal class InitRC4 : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.InitRC4; }
        }

        public void ParsePacket(Session session, Message message)
        {
            string cipherPublickey = message.NextString();

            if (!session.Crypto.InitializeRC4(cipherPublickey))
            {
                Revolution.Application.Application.Logging.WriteLine("Unable to initialize RC4!");

                session.Disconnect();

                return;
            }

            var response = new Message(SendHeaders.PublicKeyResponse);
            response.WriteString(session.Crypto.PublicKey.ToString());
            session.SendPacket(response);
        }

        #endregion
    }
}