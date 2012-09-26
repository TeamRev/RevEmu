using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuaInterface;
using System.IO;
using Revolution.Core;

namespace Revolution.Application.Api.Scripting
{
    /// <summary>
    /// Manages Lua scripts and the main Lua VM (virtual machine).
    /// </summary>
    public class LuaManager
    {
        /// <summary>
        /// Count how many scripts are loaded.
        /// </summary>
        private int ScriptCount;

        /// <summary>
        /// Holds all the script files.
        /// </summary>
        private Dictionary<dynamic, dynamic> Scripts;

        /// <summary>
        /// Folder path as a UTF-8 ASCII compliant string.
        /// </summary>
        private string FolderPath { get; set; }

        private DirectoryInfo ScriptDirectory;

        /// <summary>
        /// The virtual machine instance for Lua.
        /// </summary>
        private Lua LuaVM;


        public LuaManager(string FolderPath)
        {
            this.FolderPath = FolderPath;
            this.ScriptDirectory = new DirectoryInfo(FolderPath);
            this.LuaVM = new Lua();
        }

        public LuaManager(string FolderPath, Lua Vm)
        {
            this.FolderPath = FolderPath;
            this.ScriptDirectory = new DirectoryInfo(FolderPath);
            this.LuaVM = Vm;
        }

        public bool LoadScripts()
        {
            if (this.ScriptDirectory.Exists)
            {
                foreach (FileInfo Fi in this.ScriptDirectory.GetFiles())
                {
                    var ScriptFile = this.LuaVM.DoFile(Fi.FullName);

                    this.Scripts.Add(Fi.Name, ScriptFile);
                    Logging.GetLogging().WriteLine("Loaded " + this.Scripts.Count() + " scripts");
                    this.ScriptCount = this.Scripts.Count();
                }

                return true;
            }
            Logging.GetLogging().WriteLine("Failed to load scripts from path.");
            return false;
        }
    }
}
