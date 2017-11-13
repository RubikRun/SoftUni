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
            List<string> strs = Console.ReadLine().Split().ToList();
            string commandString = Console.ReadLine();
            string command;
            int param1, param2, l, sz;
            while (commandString != "3:1")
            {
                command = commandString.Split()[0];
                param1 = int.Parse(commandString.Split()[1]);
                param2 = int.Parse(commandString.Split()[2]);
                if (command == "merge")
                {
                    if (param1 < 0) param1 = 0;
                    for (int i = param1 + 1; i <= param2 && param1 + 1 < strs.Count; i++)
                    {
                        strs[param1] += strs[param1 + 1];
                        strs.RemoveAt(param1 + 1);
                    }
                }
                else if (command == "divide")
                {
                    if (param2 > 1)
                    {
                        l = strs[param1].Length;
                        strs.Insert(param1 + 1, strs[param1].Substring(l - l / param2 - l % param2));
                        strs[param1] = strs[param1].Substring(0, l / param2 * (param2 - 1));
                        sz = l / param2;
                        for (int i = 0; i < param2 - 2; i++)
                        {
                            l = strs[param1].Length;
                            strs.Insert(param1 + 1, strs[param1].Substring(l - sz));
                            strs[param1] = strs[param1].Substring(0, l - sz);
                        }
                    }
                }
                commandString = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", strs));
        }
    }
}
