using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem02
{
    class Program
    {
        static int letterToIndex(char letter)
        {
            return (int)letter - (int)'a';
        }
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            List<string> lines = new List<string>();
            foreach (char letter in input) lines.Add(letter + " -> " + letterToIndex(letter));

            File.WriteAllLines("output.txt", lines);
        }
    }
}
