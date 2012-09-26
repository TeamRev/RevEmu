using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using Mango.Communication;
using MySql.Data.MySqlClient;
using Revolution.Application.Communication;
using Revolution.Application.Communication.Messages.Handler;
using Revolution.Core;
using Revolution.Database;
using Revolution.Messages;

namespace Revolution.Application
{
    internal class Application
    {

        private static readonly Dictionary<string, List<string>> BannerTokensHolder =
            new Dictionary<string, List<string>>();
        static HabboServer Server;


        public static NHibernateManager DbManager;

        public static Dictionary<string, List<string>> BannerTokens
        {
            get { return BannerTokensHolder; }
        }

        public static Logging Logging
        {
            get { return Logging.GetLogging(); }
        }

     
        public static string ConnectionString { get; set; }

        private static void Initialize()
        {
            Console.Title = "Initializing Revolution Emulator....";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
         @"Helpers                                              Team Rev
          __________                                                  __________
         | Matty13      ______              _______                  | Zak
         | Joopie      (_____ \            (_______)                 | Mikkel
         | Devbest      _____) )_____ _   _ _____   ____  _   _      | Manuel
         | ItachiKM    |  __  /| ___ | | | |  ___) |    \| | | |     | Heaplink
         | Quackster   | |  \ \| ____|\ V /| |_____| | | | |_| |    
                       |_|   |_|_____) \_/ |_______)_|_|_|____/       ");
            Console.WriteLine(@"");
            Console.ResetColor();

            var time = new Stopwatch();

            Process ram = Process.GetCurrentProcess();

            Console.WriteLine("Loading Information for " + ram.ProcessName);

            var sb = new MySqlConnectionStringBuilder
                         {
                             Server = "localhost",
                             Port = 3306,
                             UserID = "root",
                             Password = "adil123",
                             Database = "revdb",
                             MinimumPoolSize = 5,
                             MaximumPoolSize = 10
                         };

            string ConnectionString = String.Format(
                "@Server={0}; Port={1}; Uid={2}; Password={3}; Database={4}; MinimumPoolSize={5}; MaximumPoolSize={6}",
                "localhost",3306,"root","adil123","revdb","5","10");

            Console.WriteLine(string.Format("Retrived MySql Details within <{0} ms> ", time.ElapsedMilliseconds));

            time.Start();

           // DbManager = new NHibernateManager(ConnectionString);


            Console.WriteLine(string.Format("Started up NHibernate Engine, with MySql Details within <{0} seconds>",
                                            time.Elapsed.Seconds));

            time.Stop();

            Console.WriteLine("");

            MessageHandler.Initialize();

            Console.Title = "Revolution Emulator";
            Server = new HabboServer();
            Console.WriteLine("Server now running.");
            
            Console.Read();
        }

        public static string BytesToChars(byte[] bytes)
        {
            return bytes.Aggregate(string.Empty, (current, b) => current + ("{" + b + "}"));
        }

        public static string GetCharFilter(string data)
        {
            string output = "";
            foreach (char o in data)
            {
                int C = o;
                if (C < 13)
                {
                    output += "{" + C + "}";
                }
                else
                {
                    output += o;
                }
            }
            return output;
        }


        public static string GetNotCharFilter(string data)
        {
            string number = "";
            string output = "";
            bool enter = false;
            foreach (char c in data)
            {
                if (c == '{')
                {
                    enter = true;
                    continue;
                }
                if (c == '}')
                {
                    output += (char) Convert.ToInt32(number);
                    number = "";
                    enter = false;
                    continue;
                }

                if (enter)
                {
                    number += c.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }

        private static void Main(string[] args)
        {
            Initialize();
          
            while (true) Console.ReadLine();
        }

        public static HabboServer GetServer()
        {
            return Server;
        }
    }
}