using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string currentResource="", currentLine;
            int currentQuantity;
            for (int i=1; true; i++)
            {
                currentLine = Console.ReadLine();
                if (currentLine == "stop") break;
                if (i % 2 == 0)
                {
                    currentQuantity = int.Parse(currentLine);
                    if (resources.ContainsKey(currentResource)) resources[currentResource] += currentQuantity;
                    else resources[currentResource] = currentQuantity;
                }
                else
                {
                    currentResource = currentLine;
                }
            }
            foreach(var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}
