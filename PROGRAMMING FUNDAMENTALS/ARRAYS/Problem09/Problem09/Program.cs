using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string input = Console.ReadLine();

            for (int i=0; i<input.Length; i++)
            {
                for (int j=0; j<letters.Length; j++)
                {
                    if (letters[j] == input[i])
                    {
                        Console.WriteLine("{0} -> {1}", input[i], j);
                    }
                }
            }
        }
    }
}
