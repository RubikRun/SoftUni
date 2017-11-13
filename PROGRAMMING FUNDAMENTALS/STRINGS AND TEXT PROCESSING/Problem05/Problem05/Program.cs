using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> lettersTransformations = new Dictionary<char, char>();
            string[] inputs = Console.ReadLine().Split();
            string word1 = inputs[0];
            string word2 = inputs[1];
            string swap;

            if (word1.Length > word2.Length)
            {
                swap = word1;
                word1 = word2;
                word2 = swap;
            }

            for (int i=0; i<word2.Length; i++)
            {
                if (lettersTransformations.ContainsKey(word2[i]))
                {
                    if (i >= word1.Length || word1[i] == lettersTransformations[word2[i]])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                else
                {
                    if (i >= word1.Length || lettersTransformations.ContainsValue(word1[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    else 
                    {
                        lettersTransformations[word2[i]] = word1[i];
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}
