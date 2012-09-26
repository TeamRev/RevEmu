using Mango.Communication.Sessions;
using Revolution.Core;

namespace Revolution.Messages.Packets.Groups
{
    internal class GroupInProfile : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.GroupInProfile; }
        }

        public void ParsePacket(Session session, Message message)
        {
            //NextInt may be ID.
            int Id = message.NextInt32();
            switch (Id)
            {
                case 1:
                    var response = new Message(462);
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteInt32(0); //state 0:Unlocked; 1: Locked; 2: Closed.
                    response.WriteString("Team Rev");
                    response.WriteString("The Epic Emulator.");
                    response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
                    response.WriteInt32(12);
                    response.WriteString("Roomname?");
                    response.WriteInt32(1); //Member?
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteString("17-03-2012");
                    response.WriteString(string.Empty);
                    response.WriteString("wizcsharp");
                    response.WriteString(string.Empty);
                    response.WriteInt32(0);
                    session.SendPacket(response);
                    break;
                case 2:
                    response = new Message(462);
                    response.WriteInt32(2);
                    response.WriteBool(true);
                    response.WriteInt32(0); //state 0:Unlocked; 1: Locked; 2: Closed.
                    response.WriteString("PacketEmu is gay");
                    response.WriteString("Freaking gay!");
                    response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
                    response.WriteInt32(12);
                    response.WriteString("Roomname?");
                    response.WriteInt32(1); //Member?
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteString("17-03-2012");
                    response.WriteString(string.Empty);
                    response.WriteString("wizcsharp");
                    response.WriteString(string.Empty);
                    response.WriteInt32(0);
                    session.SendPacket(response);
                    break;
                case 3:
                    response = new Message(462);
                    response.WriteInt32(3);
                    response.WriteBool(true);
                    response.WriteInt32(0); //state 0:Unlocked; 1: Locked; 2: Closed.
                    response.WriteString("Some Noob");
                    response.WriteString("Fuck yeah");
                    response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
                    response.WriteInt32(12);
                    response.WriteString("Roomname?");
                    response.WriteInt32(1); //Member?
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteString("17-03-2012");
                    response.WriteString(string.Empty);
                    response.WriteString("wizcsharp");
                    response.WriteString(string.Empty);
                    response.WriteInt32(0);
                    session.SendPacket(response);
                    break;
                case 4:
                    response = new Message(462);
                    response.WriteInt32(4);
                    response.WriteBool(true);
                    response.WriteInt32(0); //state 0:Unlocked; 1: Locked; 2: Closed.
                    response.WriteString("Bored, eh'");
                    response.WriteString("Bite me! |");
                    response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
                    response.WriteInt32(12);
                    response.WriteString("Roomname?");
                    response.WriteInt32(1); //Member?
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteString("17-03-2012");
                    response.WriteString(string.Empty);
                    response.WriteString("wizcsharp");
                    response.WriteString(string.Empty);
                    response.WriteInt32(0);
                    session.SendPacket(response);
                    break;
                case 5:
                    response = new Message(462);
                    response.WriteInt32(5);
                    response.WriteBool(true);
                    response.WriteInt32(0); //state 0:Unlocked; 1: Locked; 2: Closed.
                    response.WriteString("Hail Kryptos!");
                    response.WriteString("FUCKING DO IT!! |");
                    response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
                    response.WriteInt32(12);
                    response.WriteString("Roomname?");
                    response.WriteInt32(1); //Member?
                    response.WriteInt32(1);
                    response.WriteBool(true);
                    response.WriteString("17-03-2012");
                    response.WriteString(string.Empty);
                    response.WriteString("Kryptos");
                    response.WriteString(string.Empty);
                    response.WriteInt32(0);
                    session.SendPacket(response);
                    break;
            }
        }

        #endregion
    }
}