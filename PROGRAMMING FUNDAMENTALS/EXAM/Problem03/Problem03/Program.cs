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
            string encoded = Console.ReadLine();
            string placeholderPattern = @"([A-Za-z]+)(.*)\1";
            List<string> placeholders = Regex.Split(Console.ReadLine(), "[{}]+").Skip(1).ToList();
            List<string> fixedPlaceholders = new List<string>();
            List<int> placeholdersIndexes = new List<int>();
            List<int> placeholdersLengths = new List<int>();
            placeholders.RemoveAt(placeholders.Count - 1);

            int i = 0;
            foreach (Match match in Regex.Matches(encoded, placeholderPattern))
            {
                fixedPlaceholders.Add(match.Groups[1].Value + placeholders[i++] + match.Groups[1].Value);
                placeholdersIndexes.Add(encoded.IndexOf(match.Value));
                placeholdersLengths.Add(match.Length);
            }

            Console.Write(encoded.Substring(0, placeholdersIndexes[0]));
            for (i = 0; i < fixedPlaceholders.Count - 1; i++)
            {
                Console.Write(fixedPlaceholders[i]);
                Console.Write(encoded.Substring(placeholdersIndexes[i] + placeholdersLengths[i], placeholdersIndexes[i + 1] - placeholdersIndexes[i] - placeholdersLengths[i]));
            }
            Console.Write(fixedPlaceholders.Last());
            Console.Write(encoded.Substring(placeholdersIndexes.Last() + placeholdersLengths.Last()));
        }
    }
}
