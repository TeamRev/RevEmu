using System;
using System.Collections.Generic;
using System.Reflection;
using Mango.Communication.Sessions;
using Revolution.Application.Util;
using Revolution.Core;
using Revolution.Messages;
using Revolution.Messages.Packets;

namespace Revolution.Application.Communication.Messages.Handler
{
    internal class MessageHandler
    {
        private static readonly Dictionary<uint, object> Messages = new Dictionary<uint, object>();

        /// <summary>
        /// Storage of names from Info Events.
        /// </summary>
        public static Dictionary<string, uint> InfoEvents;

        public static void Initialize()
        {
            int messagesCount = 0;

            InfoEvents = new Dictionary<string, uint>();

            foreach (var Packet in typeof(RevcHeaders).GetFields())
            {
                var PacketId = (uint)Packet.GetValue(0);
                var PacketName = Packet.Name;

                if (!InfoEvents.ContainsValue(PacketId))
                {
                    InfoEvents.Add(PacketName, PacketId);
                }
            }

            foreach (Type t in Assembly.GetCallingAssembly().GetTypes())
            {
                if (t.GetInterface("IPacketEvent") != null)
                {
                    var message = Activator.CreateInstance(t) as IPacketEvent;

                    if (message != null) Messages.Add(message.EventId, message);

                    messagesCount++;
                }
            }

            Application.Logging.WriteLine(string.Format("RevEmu invoked: {0} Events.", messagesCount));
        }

        public static string GetName(uint Header)
        {
            using (DictionaryAdapter<string, uint> DA = new DictionaryAdapter<string, uint>(InfoEvents))
            {
                return DA.TryPopKey(Header);
            }
        }

        public static void Execute(Session session, Message message)
        {
            if (!Messages.ContainsKey((uint) message.HeaderId))
            {
                Application.Logging.WriteLine(string.Format("Not found: {0}", message.HeaderId), Logging.Status.Warning);
                return;
            }

            var handler = Messages[(uint)message.HeaderId] as IPacketEvent;

            if (handler != null)
            {
                Application.Logging.WriteLine(string.Format("Invoked: {0} -> {1}", handler.EventId, GetName(handler.EventId),
                                              Logging.Status.Invoker));

                DelHandle delHandle = handler.ParsePacket;

                delHandle.Invoke(session, message);
            }
        }

        #region Nested type: DelHandle

        private delegate void DelHandle(Session session, Message message);

        #endregion
    }
}