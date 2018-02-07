using System;
using System.Collections.Generic;

namespace Problem10
{
    class Program
    {
        static string appliedCommand(string command, string text)
        {
            int commandType = command[0] - '0';
            string argument = command.Substring(2);

            if (commandType == 1)
            {
                return text + argument;
            }
            else if (commandType == 2)
            {
                return text.Substring(0, text.Length - int.Parse(argument));
            }
            return text;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = "", command;
            Stack<string> textStates = new Stack<string>();

            for (int i=0; i<n; i++)
            {
                command = Console.ReadLine();
                if (command[0] == '1' || command[0] == '2')
                {
                    textStates.Push(text);
                    text = appliedCommand(command, text);
                }
                else if (command[0] == '3')
                {
                    Console.WriteLine(text[int.Parse(command.Substring(2)) - 1]);
                }
                else
                {
                    text = textStates.Pop();
                }
            }
        }
    }
}
