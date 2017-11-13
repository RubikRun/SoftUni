using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedWord = Console.ReadLine();
            string text = Console.ReadLine();
            string sentenceSplitPattern = @"[.?!]+\s?", wordsSplitPattern = "[^A-Za-z]+";
            string[] sentences = Regex.Split(text, sentenceSplitPattern);
            foreach(string sentence in sentences)
            {
                if (Regex.Split(sentence, wordsSplitPattern).Contains(wantedWord))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
