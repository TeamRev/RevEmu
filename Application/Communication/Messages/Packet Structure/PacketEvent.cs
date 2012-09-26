using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages
{
    internal interface IPacketEvent
    {
        uint EventId { get; }
        void ParsePacket(Session session, Message message);
    }
}