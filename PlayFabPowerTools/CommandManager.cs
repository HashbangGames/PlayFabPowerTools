﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayFabPowerTools
{
    public class CommandManager
    {
        //ENUM for available commands
        public enum CommandTypes { UNKNOWN, HELP, CLEAR, EXIT, PUBLISH, VERSION, PULL, BUILD }

        public CommandTypes GetCommand(string arg)
        {
            switch (arg.ToLower())
            {
                case "help":
                case "/help":
                case "/?":
                    return CommandTypes.HELP;
                case "exit":
                case "/exit":
                    return CommandTypes.EXIT;
                case "clear":
                    return CommandTypes.CLEAR;
                case "publish":
                    return CommandTypes.PUBLISH;
                case "version":
                    return CommandTypes.VERSION;
                case "pull":
                    return CommandTypes.PULL;
                case "build":
                    return CommandTypes.BUILD;
                default:
                    return CommandTypes.UNKNOWN;
            }

        }

        public static void Prompt(){
            Console.WriteLine("");
            Console.Write(">");
        }

        public static void WriteAsync(string msg, ConsoleColor color)
        {
            Write(msg, color);
            Prompt();
        }

        public static void Write(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();

        }

    }
}
