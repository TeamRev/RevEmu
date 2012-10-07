using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Revolution.Revision.R63.Game.Habbo.Controller;
using Revolution.Core;

namespace Revolution.Application.ScriptEngine
{
    class ScriptCore
    {
        public HabboController Habbo(int id)
        {
            return new HabboController(id);
        }

        public SystemConsole Console()
        {
            return new SystemConsole();
        }

        public Message Message()
        {
            return new Message();
        }
    }
}
