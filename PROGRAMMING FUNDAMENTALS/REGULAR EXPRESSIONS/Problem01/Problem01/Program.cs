using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex emailPattern = new Regex(@"\s[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+\.[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+");
            foreach(Match match in emailPattern.Matches(input))
            {
                Console.WriteLine(match);
            }
        }
    }
}
