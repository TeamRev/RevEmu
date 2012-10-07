using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revolution.Application.ScriptEngine
{
    class SystemConsole
    {
        public SystemConsole()
        {
 
        }

        public void Log(object message)
        {
            Console.Write(message);
        }
    }
}
