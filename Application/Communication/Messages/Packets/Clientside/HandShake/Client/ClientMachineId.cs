using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.HandShake.Client
{
    internal class ClientMachineId : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.ClientMachineId; }
        }

        public void ParsePacket(Session session, Message message)
        {
            string MachineID = message.NextString();

            session.MachineID = MachineID;
        }

        #endregion
    }
}