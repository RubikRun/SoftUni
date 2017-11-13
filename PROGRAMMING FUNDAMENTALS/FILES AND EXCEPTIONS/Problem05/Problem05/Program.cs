using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            int currLine = 0;
            List<string> outputLines = new List<string>();

            Dictionary<string, int> quantities = new Dictionary<string, int>();
            string currInput = "", currResource;
            int currQuantity;
            while (currInput != "stop")
            {
                currInput = inputLines[currLine++];
                if (currInput == "stop") break;
                currResource = currInput;
                currInput = inputLines[currLine++];
                if (currInput == "stop") break;
                currQuantity = int.Parse(currInput);

                if (quantities.ContainsKey(currResource))
                {
                    quantities[currResource]+=currQuantity;
                }
                else
                {
                    quantities[currResource] = currQuantity;
                }
            }
            foreach(var quantity in quantities)
            {
                outputLines.Add(String.Format("{0} -> {1}", quantity.Key, quantity.Value));
            }
            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
