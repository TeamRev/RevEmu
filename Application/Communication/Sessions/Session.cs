using System;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Revolution.Application.Communication;
using Revolution.Application.Communication.Messages.Handler;
using Revolution.Core;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using Revolution.Messages;
using SuperSocket.Facility;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Revision.R63B.Game.Rooms.Objects.Habbo;


namespace Mango.Communication.Sessions
{
    public class Session : AppSession<Session>
    {
        public Protocol Crypto;
        private bool _disconnectedCalled;
        public string MachineID = "";
        public int X;
        public HabboController Habbo;

        public HabboRoomObject habboRoomObject;

        public string ReleaseBuild;

        public int Y;

        private int id;


        public Session()
        {
            
        }

        public override void StartSession()
        {
            int i = 0;
            this.id = i++;
            base.StartSession();
            Console.WriteLine("Session {0} started", this.id);
         
        }

        
        /// <summary>
        /// This method is called when data has been received.
        /// </summary>
        /// <param name="bytes">The array of data as bytes.</param>
        public void HandleSecurity(byte[] bytes)
        {
            try
            {
                if (Crypto != null)
                {
                    if (Crypto.Initialized)
                    {
                        bytes = Crypto.Rc4.Decipher(bytes);
                    }
                }

                while (bytes != null)
                {
                    var message = new Message(bytes);

                    MessageHandler.Execute(this, message);

                    bytes = message.BytesRemain;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Forces this player to be disconnected
        /// </summary>
        public void Disconnect()
        {
            if (!_disconnectedCalled)
            {
                _disconnectedCalled = true;
                base.Close();
                
            }
        }

        public void SendPacket(Message packet)
        {
            SendData(packet.GetBytes);
        }

        public void SendData(byte[] data)
        {
            base.SendResponse(data);
        }

        public void SendData(string Data)
        {
            SendData(Encoding.UTF8.GetBytes(Data));
        }


        
    }
}
