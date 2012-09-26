using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolution.Core;

namespace Revolution.Application.Messages.Packets.Serverside.HandShake
{
    class PolicyCheck
    {
        public Message Parse(Message instance)
        {
            
            instance.WriteString("<?xml version=\"1.0\"?> " +
                                   "<!DOCTYPE cross-domain-policy SYSTEM \"/xml/dtds/cross-domain-policy.dtd\"> " +
                                   "<cross-domain-policy> " +
                                   "<allow-access-from domain=\"*\" to-ports=\"*\" /> " +
                                   "</cross-domain-policy>\x0");
            return instance;
        }
    }
}
