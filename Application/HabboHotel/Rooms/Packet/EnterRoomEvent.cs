using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Revision.R63B.Game.Rooms.Packet
{
    /// <summary>
    /// Loads user in room.
    /// </summary>
    internal class EnterOnRoom : IPacketEvent
    {
        #region PacketEvent Members

        /// <summary>
        /// Event id for current Packet
        /// </summary>
        public uint EventId
        {
            get { return RevcHeaders.EnterOnRoom; }
        }

        /// <summary>
        /// Handles Packet, for current user, and message event.
        /// </summary>
        /// <param name="gameclient">User of Packet</param>
        /// <param name="Message">Message for User</param>
        public void ParsePacket(Session session, Message message)
        {
            var Response = new Message(2348);
            session.SendPacket(Response);

            Response = new Message(1399);
            Response.WriteString("model_f"); // Room Model
            Response.WriteInt32(1); // id ?
            session.SendPacket(Response);

            Response = new Message(2771);
            Response.WriteString("wallpaper"); // Wallpaper 
            Response.WriteString("110"); // Height / Width
            session.SendPacket(Response);

            Response = new Message(2771);
            Response.WriteString("floor"); // Floor
            Response.WriteString("110"); // Height / Width
            session.SendPacket(Response);

            Response = new Message(3998);
            Response.WriteInt32(4);
            session.SendPacket(Response);

            Response = new Message(3083);
            Response.WriteInt32(2);
            Response.WriteBool(false);
            session.SendPacket(Response);

            Response = new Message(831);
            session.SendPacket(Response);

            Response = new Message(2771);
            Response.WriteString("landscape"); // Landscape
            Response.WriteString("10.0"); // Height / Width
            session.SendPacket(Response);

            Response = new Message(2101);
            Response.WriteString("-1");
            session.SendPacket(Response);
        }

        #endregion
    }
}