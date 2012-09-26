using System;

namespace Revolution.Core
{
    internal class Logging
    {
        #region Status enum

        public enum Status
        {
            Invoker,
            Log,
            Debug,
            Information,
            Warning,
            Error
        }

        #endregion

        private static Logging _instance;

        private static readonly object LockObj = new object();

        public static Logging GetLogging()
        {
            if (_instance == null)
            {
                _instance = new Logging();
            }

            return _instance;
        }

        public void WriteLine(string line)
        {
            WriteLine(line, Status.Information);
        }

        public void WriteLine(string line, Status status)
        {
            lock (LockObj)
            {
                StatusColor(status);

                Console.WriteLine(" {0} \xBB {1}", "<RevEmu>", line);
            }
        }

        public void StatusColor(Status status)
        {
            Console.ResetColor();

            switch (status)
            {
                case Status.Invoker:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case Status.Log:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Status.Debug:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case Status.Information:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case Status.Warning:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Status.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
        }
    }
}