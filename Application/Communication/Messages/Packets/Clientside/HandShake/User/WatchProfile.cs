using System;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Revision.R63.Game.Habbo.Controller;

namespace Revolution.Messages.Packets.HandShake.User
{
    internal class WatchProfile : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.WatchProfile; }
        }

        public void ParsePacket(Session session, Message message)
        {
            int userId = message.NextInt32();

            //var profile = new HabboSqlData(userId);
            var profile = new HabboController(userId);
            var Response = new Message(SendHeaders.WatchProfile);
            Response.WriteInt32(profile.id);
            Response.WriteString(profile.username);
            Response.WriteString(profile.figure);
            Response.WriteString(profile.motto);
            Response.WriteString("22-07-2012");
            Response.WriteInt32(10);
            Response.WriteInt32(1);
            Response.WriteBool(false);
            Response.WriteBool(false);
            Response.WriteBool(false);
            Response.WriteInt32(0);
            Response.WriteInt32(60000);
            Response.WriteBool(true);
            session.SendPacket(Response);
            //[LOG] > CLIENT ID: '462': [0][0][1]d[1]Î[0][4]û^[1][0][0][0][0][0] [Âµ] Train Station [Âµ] NYC [Âµ][0]?This is a famous New York City station known as 'Grand Central'                                     One of the best modes of transportation![0]>b06134s02134s97114t50013t50015b62a5d12f09ff0d1a5365a20ad7301af[3]Qðg[0]>Âµ T R A I N   S T A T I O N Âµ New York Âµ  armypolicedatefbi[0][0][0][1][0][0][3]Ý[1][0][10]17-03-2012[0][0][0][6]JakeSS[0][0][0][0][0][0]
            //var Response = new Message(SendHeaders.WatchProfile);
            //Response.WriteInt32(profile.Getid);
            //Response.WriteString(profile.username);
            //Response.WriteString(profile.GetLook());
            //Response.WriteString(profile.motto);
            //Response.WriteString(profile.GetCreationDate());
            //Response.WriteInt32(1337);
            //Response.WriteInt32(2);
            //Response.WriteBool(false); // online?
            //Response.WriteBool(false);
            //Response.WriteBool(profile.GetStatus());
            //Response.WriteInt32(5);
            //Response.WriteInt32(1); //GroupId
            //Response.WriteString("Team Rev");
            //Response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
            //Response.WriteString("242424");
            //Response.WriteString("242424");
            //Response.WriteBool(false); //Favorite?
            //Response.WriteInt32(2); //GroupId
            //Response.WriteString("PacketEmu Is Gay.");
            //Response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
            //Response.WriteString("242424");
            //Response.WriteString("242424");
            //Response.WriteBool(false); //Favorite?
            //Response.WriteInt32(3); //GroupId
            //Response.WriteString("Some Noob");
            //Response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
            //Response.WriteString("242424");
            //Response.WriteString("242424");
            //Response.WriteBool(false); //Favorite?
            //Response.WriteInt32(4); //GroupId
            //Response.WriteString("Bored, eh'");
            //Response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
            //Response.WriteString("242424");
            //Response.WriteString("242424");
            //Response.WriteBool(false); //Favorite?
            //Response.WriteInt32(5); //GroupId
            //Response.WriteString("Hail Kryptos!");
            //Response.WriteString("b22114s97114b8aaa7c5101e6bcb6eff94df1b669f0f");
            //Response.WriteString("242424");
            //Response.WriteString("242424");
            //Response.WriteBool(true); //Favorite?
            //Response.WriteInt32(((int) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds -
            //                     profile.GetLastAccess()));
            //    //((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds - (int)User.HabboUser.UserRow["lastaccess"])
            //Response.WriteBool(true);
            //session.SendPacket(Response);
        }

        #endregion
    }
}