using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentCommand = Console.ReadLine();
            var contacts = new SortedDictionary<string, string>();

            while (currentCommand != "END")
            {
                var commandParts = currentCommand.Split();
                if (commandParts[0] == "A")
                {
                    contacts[commandParts[1]] = commandParts[2];
                }
                else if (commandParts[0] == "S")
                {
                    if (contacts.ContainsKey(commandParts[1]))
                    {
                        Console.WriteLine("{0} -> {1}", commandParts[1], contacts[commandParts[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", commandParts[1]);
                    }
                }
                else if (commandParts[0] == "ListAll")
                {
                    Console.WriteLine(String.Join("\n", contacts.Select(x => x.Key + " -> " + x.Value)));
                }
                currentCommand = Console.ReadLine();
            }
        }
    }
}
