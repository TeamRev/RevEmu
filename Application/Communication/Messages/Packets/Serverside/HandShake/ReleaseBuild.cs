using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolution.Core;

namespace Revolution.Application.Messages.Packets.Serverside.HandShake
{
    class ReleaseBuild
    {
        public Message Parse(Message instance)
        {
            // #EVENT 4000
            //[0][0][0]# [0]RELEASE63-201207231112-16380487[0][0][0][6][3]Â[0][0][0][0]

            // [0][0][0]# INT Length
            // #   SHORT ID
            // [0] False
            // RELEASE63-201207231112-16380487 STRING Build
            // [0][0][0][6] INT 6
            // [3]Â SHORT ID
            // [0][0][0][0] INT 0

            return instance;
        }
    }
}
