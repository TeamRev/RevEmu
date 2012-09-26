using System;
using System.Collections.Generic;
using System.IO;

namespace Revolution.Core
{
    internal class Config
    {
        private static Config _instance;

        public Dictionary<string, string> Data;

        public Config(string file)
        {
            Data = new Dictionary<string, string>();

            if (!File.Exists(file))
            {
                throw new Exception("Unable to locate configuration file at '" + file + "'.");
            }

            try
            {
                using (var stream = new StreamReader(file))
                {
                    string line = null;

                    while ((line = stream.ReadLine()) != null)
                    {
                        if (line.Length < 1 || line.StartsWith("#"))
                        {
                            continue;
                        }

                        if (line.Contains("="))
                        {
                            var key = line.Split('=')[0];
                            var val = line.Split('=')[1];

                            Data.Add(key, val);
                        }
                    }

                    stream.Dispose();
                    stream.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not process configuration file: " + e.Message);
            }
        }

        public static Config GetConfig(string file = "")
        {
            if (_instance == null)
            {
                _instance = new Config(file);
            }

            return _instance;
        }
    }
}