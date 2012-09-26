using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mango.Communication.Sessions;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Config;

namespace Revolution.Application.Communication
{
    public class HabboServer : AppServer<Session>
    {
        public HabboServer()
        {
            /* Get the primary config for the sockets. */
            SuperSocket.SocketBase.Config.RootConfig r = new SuperSocket.SocketBase.Config.RootConfig();

            /* Allow's errors to be printed onto the console screen! */
            r.LoggingMode = LoggingMode.Console;

            /* Get the config for the HabboServer*/
            SuperSocket.SocketBase.Config.ServerConfig s = new SuperSocket.SocketBase.Config.ServerConfig();

            s.Name = "HabboServer";
            s.ServiceName = "HabboServer";
            s.Ip = "Any";
            s.Port = 90;
            s.Mode = SocketMode.Async;
            
            

            SuperSocket.SocketEngine.SocketServerFactory f = new SuperSocket.SocketEngine.SocketServerFactory();

            base.Setup(r, s, f);
            base.Start();
           
            
        }

        protected override void OnStartup()
        {
            base.OnStartup();
        }
		


     
    }
}
