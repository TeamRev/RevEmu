using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noesis.Javascript;
using Revolution.Core;
using Revolution.Revision.R63.Game.Habbo.Controller;
using System.IO;

namespace Revolution.Application.ScriptEngine
{
    /// <summary>
    /// Manages script files.
    /// </summary>
    class Manager
    {
        private JavascriptContext ScriptContext = new JavascriptContext();
        private string Path = @"C:\scripts\";

        public void Init()
        {
          
            this.ScriptContext.SetParameter("Scripting",new ScriptCore());
            
        }

        public void Start()
        {

            foreach (string file in Directory.EnumerateFiles(this.Path, "*.js"))
            {
                string text = File.ReadAllText(file);
                this.ScriptContext.Run(text);
            }
        }

        
    }
}
