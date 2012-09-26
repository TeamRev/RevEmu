using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MySql.Data.MySqlClient;

namespace Revolution.Core.Noobstall
{
    internal class Install
    {
        public string ConnectionString;
        private bool _isInstalled;

        public Install SetNoobSettings(bool result)
        {
            _isInstalled = result;
            return this;
        }

        public Install RunNoobStall()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Not Installed?
            if (!_isInstalled)
            {
                // Then Run The Installer
                Console.WriteLine("{Installer} => Starting Up Noobstall Engine v1.32");
                Console.WriteLine();
                // Engine Ready?
                //IniConfigSource source = new IniConfigSource(@"RevSettings.ini");

                //IConfig mysqlConfig = source.Configs["MySql"];
                // Go go go
                Console.WriteLine("{Installer} => Engine started! Preparing Details");
                Console.WriteLine();
                var sb = new MySqlConnectionStringBuilder();

                Console.WriteLine("{Installer} => (Sql) => MySql Engine Ready!");
                Console.WriteLine();
                Console.WriteLine("{Installer} => (Sql) => Please Enter Your Host");

                string host = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(host))
                {
                    Console.WriteLine();
                    Console.WriteLine("{Installer} => (Sql) => You Left Your Host Empty! Please Enter Your Host again!");
                    Console.WriteLine();
                    host = Console.ReadLine();
                }

                // Set In Sql.
                sb.Server = host;
                Console.WriteLine();
                Console.WriteLine("{Installer} => (Sql) => Please Enter Your Sql Port");
                string port = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(port))
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        "{Installer} => (Sql) => Your Port Cannot Be 0 Or Empty! Please Try Entering Your Port Again!");
                    port = Console.ReadLine();
                    Console.WriteLine();
                }

                sb.Port = uint.Parse(port);

                Console.WriteLine("{Installer} => (Sql) => Please Enter Your Username");
                Console.WriteLine();
                string username = Console.ReadLine();
                Console.WriteLine();

                while (string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine(
                        "{Installer} => (Sql) => Your Username Appears To Contain Whites Spaces, Or Is Null, Please Enter It Again");
                    Console.WriteLine();
                    username = Console.ReadLine();
                    Console.WriteLine();
                }

                sb.UserID = username;

                Console.WriteLine(
                    "{Installer} => (Sql) => Please Enter Your Password, Do Not Worry The Password Is Encrypted");

                Console.WriteLine();
                string password = GetPassword();

                Console.WriteLine();
                sb.Password = password;

                ConnectionString = sb.ToString();

                //mysqlConfig.Set("MySQL_Host", host);
                //mysqlConfig.Set("MySQL_Port", uint.Parse(port));
                //mysqlConfig.Set("MySQL_Username", username);
                //mysqlConfig.Set("MySQL_Password", password);
            }

            _isInstalled = true;

            Console.ForegroundColor = ConsoleColor.White;

            return this;
        }

        /// <summary>
        ///   Read a line but mask the password as it is typed.
        /// </summary>
        internal string GetPassword()
        {
            var password = new StringBuilder();

            var cursorHistory = new Stack<Point>();

            ConsoleKeyInfo key;
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace)
                {
                    cursorHistory.Push(new Point(Console.CursorLeft, Console.CursorTop));
                    password.Append(key.KeyChar);
                    Console.Write('*');
                }
                else
                {
                    if (password.Length == 0)
                        continue;

                    password.Length--;

                    Point backCursor = cursorHistory.Pop();
                    Console.SetCursorPosition(backCursor.X, backCursor.Y);
                    Console.Write(' ');
                    Console.SetCursorPosition(backCursor.X, backCursor.Y);
                }
            }

            return password.ToString();
        }
    }
}