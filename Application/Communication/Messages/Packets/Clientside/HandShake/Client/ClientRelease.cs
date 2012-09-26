using System;
using Mango.Communication.Sessions;
using Revolution.Core;


namespace Revolution.Messages.Packets.HandShake
{
    internal class ClientRelase : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.ClientRelease; }
        }

        public void ParsePacket(Session session, Message message)
        {
            string releaseBuild = message.NextString();
            Application.Application.Logging.WriteLine(string.Format("Client release: {0}", releaseBuild), Logging.Status.Debug);
            Console.Title += string.Format(" | Invoked on Revision: {0}, Loading Packets...", releaseBuild);

            session.ReleaseBuild = releaseBuild;
        }

        #endregion
    }
}