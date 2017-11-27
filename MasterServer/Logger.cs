﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterServer
{
    public enum LogLevels
    {
        Debug,
        Normal,
        Warning,
        Error
    }

    class Logger
    {
        public static void Log(LogLevels level, string msg)
        {
            switch (level)
            {
                case LogLevels.Debug:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogLevels.Normal:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case LogLevels.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevels.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {msg}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
