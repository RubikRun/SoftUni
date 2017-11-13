using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skipTake = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            string pattern = @"\|<.{" + skipTake[0] + "}([^|<]{1," + + skipTake[1] + "})";
            List<string> outputs = new List<string>();

            foreach (Match match in Regex.Matches(text, pattern))
            {
                outputs.Add(match.Groups[1].Value);
            }
            Console.WriteLine(String.Join(", ", outputs));
        }
    }
}
