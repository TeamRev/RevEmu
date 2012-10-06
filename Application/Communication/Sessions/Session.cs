using System;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Revolution.Application.Communication;
using Revolution.Application.Communication.Messages.Handler;
using Revolution.Core;
using Revolution.Messages;
using SuperSocket.Facility;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Revision.R63B.Game.Rooms.Objects.Habbo;


namespace Mango.Communication.Sessions
{
    public class Session
    {
        public Protocol Crypto;
        private bool _disconnectedCalled;
        public string MachineID = "";
        public int X;
        public HabboController Habbo;
        private byte[] buffer = new byte[1024];
        public HabboRoomObject habboRoomObject;
        public Socket Socket;
        public string ReleaseBuild;
        private ServerSocket Manager;

        public int Y;

        public int Id;


        public Session(int id, ServerSocket ServerSocket)
        {
            this.Manager = ServerSocket;
            this.Id = id;
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
                
                
            }
        }

        public void SendPacket(Message packet)
        {
            SendData(packet.GetBytes);
        }

        public void SendData(byte[] data)
        {
            
        }

        public void SendData(string Data)
        {
            SendData(Encoding.UTF8.GetBytes(Data));
        }

       
        


        
    }
}
