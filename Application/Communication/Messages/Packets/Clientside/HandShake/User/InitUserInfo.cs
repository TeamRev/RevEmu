using System;
using System.Collections.Generic;
using Mango.Communication.Sessions;
using Revolution.Application.HabboHotel.Habbo.Distributor;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Revision.R63.Game.Habbo.Friends.Controller;
using Revolution.Revision.R63B.Game;

namespace Revolution.Application.Communication.Messages.Packets.Clientside.HandShake.User
{

    internal class InitUserInfo : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.InitializeUserInformation; }
        }

        public void ParsePacket(Session session, Message message)
        {
            Console.Title = string.Format("Revolution Emulator | Invoked on Revision: {0}, Packets loaded!", session.ReleaseBuild);

            var Response = new Message(SendHeaders.InitUser);
            Response.WriteInt32(session.Habbo.id); //id
            Response.WriteString(session.Habbo.username); //username
            Response.WriteString(session.Habbo.figure); //look
            Response.WriteString(session.Habbo.gender.ToUpper()); //gender M/F
            Response.WriteString(session.Habbo.motto);
            Response.WriteString(session.Habbo.username); //real name????
            Response.WriteBool(true);
            Response.WriteInt32(0); // Respect
            Response.WriteInt32(3); // Daily Respect Points
            Response.WriteInt32(3); // Daily Pet Respect Points
            Response.WriteBool(true);
            Response.WriteString("31-07-2012 12:28:40");
            Response.WriteBool(false);
            Response.WriteBool(false);
            session.SendPacket(Response);

            Response = new Message(2967);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(416);
            Response.WriteInt32(90);
            session.SendPacket(Response);

            Response = new Message(2594);
            Response.WriteInt32(25000);
            session.SendPacket(Response);

            Response = new Message(3841);
            Response.WriteInt32(0);
            Response.WriteInt32(-1);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(3786);
            Response.WriteString("100a65a9efd436dc996cbss6");
            session.SendPacket(Response);
            //List<FriendController> friends = new FriendController(session.Habbo.id).GetMyFriends(session.Habbo.id);

            //session.SendAlert("Zak's a faggot");

            Response = new Message(SendHeaders.FriendBarInit);
            Response.WriteInt32(100);
            Response.WriteInt32(100);
            Response.WriteInt32(200);
            Response.WriteInt32(300);

            Response.WriteInt32(0); //count friend group


            Response.WriteInt32(1); //Count friends

            HabboController friendData = new HabboController(2);
            Response.WriteInt32(friendData.id);
            Response.WriteString(friendData.username); //Username
            Response.WriteInt32(1); //?
            Response.WriteBool(true); //Online/Offline
            Response.WriteBool(false); //InRoom
            Response.WriteString(friendData.figure);
            Response.WriteInt32(2);
            Response.WriteString(friendData.motto);
            Response.WriteString("Super Admin");
            Response.WriteString("22-07-2012");
            Response.WriteBool(false);

            //var FriendbarTwo = new HabboController(2);
            /*for (int i = 0; i < friends.Count; i++)
            {
                HabboController friendData = new HabboController(i);
                Response.WriteInt32(friendData.id);
                Response.WriteString(friendData.username); //Username
                Response.WriteInt32(1); //?
                Response.WriteBool(true); //Online/Offline
                Response.WriteBool(false); //InRoom
                Response.WriteString(friendData.figure);
                Response.WriteInt32(2);
                Response.WriteString(friendData.motto);
                Response.WriteString("Super Admin");
                Response.WriteString("22-07-2012");
                Response.WriteBool(false);
            }*/


            Response.WriteInt32(100);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(2026);
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(3841);
            Response.WriteInt32(0);
            Response.WriteInt32(-1);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(3443);
            Response.WriteBool(true);
            Response.WriteString("lympix1");
            Response.WriteInt32(0);
            Response.WriteInt32(30);
            Response.WriteInt32(-1);
            Response.WriteInt32(10);
            Response.WriteBool(false);
            Response.WriteString("CHANGE_FIGURE");
            Response.WriteInt32(0);
            Response.WriteString(string.Empty);
            Response.WriteString("1343121901227");
            Response.WriteInt32(0);
            Response.WriteInt32(1);
            Response.WriteInt32(1);
            Response.WriteString(string.Empty);
            Response.WriteString("keepcalm");
            Response.WriteBool(true);
            Response.WriteInt32(1);
            Response.WriteInt32(0);
            session.SendPacket(Response);

            Response = new Message(2275);
            Response.WriteString("2012-08-12 00:00,olympicDecorator");
            Response.WriteString(string.Empty);
            session.SendPacket(Response);
        }

        #endregion
    }
}