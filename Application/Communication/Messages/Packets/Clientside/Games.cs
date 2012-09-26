using System;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Revision.R63.Game.Habbo.Controller;

namespace Revolution.Messages.Packets
{
    internal class SnowWarTokens : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SnowWarTokens; }
        }

        public void ParsePacket(Session session, Message message)
        {
            //[LOG] > CLIENT ID: '785': [0][0][0][3] [0][0][0][0] [0][0][0][0] [0][0][0][1] [0][0][0][10]
            //[LOG] > CLIENT ID: '3721': [0][0][0][0][0]*6[0]GET_SNOWWAR_TOKENS[0][0][0][1]

            var response = new Message(785);
            response.WriteInt32(0);
            response.WriteInt32(0);
            response.WriteInt32(1);
            response.WriteInt32(10);
            session.SendPacket(response);

            response = new Message(3721);
            response.WriteInt32(1);
            response.WriteString("GET_SNOWWAR_TOKENS");
            response.WriteInt32(1);
            session.SendPacket(response);
        }

        #endregion
    }

    internal class SnowWarTopList : IPacketEvent
    {
        #region PacketEvent Members

        public uint EventId
        {
            get { return RevcHeaders.SnowWarTopList; }
        }

        public void ParsePacket(Session session, Message message)
        {
            /*
             * ItemCount Int32
             * UserId Int32
             * Score Int32
             * Position Int32
             * Username String
             * Figure String
             * Gender String
             * Int32(1)
             * Int32(1)
             */

            //TODO: USE DISTRIBUTOR TO JUST GET USER FROM CACHE.
            int userid = message.NextInt32();

            HabboController user = new HabboController(userid);

            var response = new Message(2048);
            response.WriteInt32(1); // User Count
            response.WriteInt32(userid);
            response.WriteInt32(0); // TODO: Make column for  SCORE
            response.WriteInt32(1); // TODO: Make a void that filters the scores and sets the rank.
            response.WriteString(user.username);
            response.WriteString(user.figure);
            response.WriteString(user.gender);
            response.WriteInt32(1);
            response.WriteInt32(1);
            session.SendPacket(response);
        }

        #endregion
    }
}