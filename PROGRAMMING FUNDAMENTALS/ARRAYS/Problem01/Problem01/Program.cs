using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static int CommonStartLength(string[] words1, string[] words2)
        {
            int length = 0;
            for (int i=0; i<Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[i] != words2[i]) break;
                length++;
            }
            return length;
        }
        static int CommonEndLength(string[] words1, string[] words2)
        {
            int length = 0;
            for (int i=0; i<Math.Min(words1.Length, words2.Length); i++)
            {
                if (words1[words1.Length-1-i] != words2[words2.Length-1-i]) break;
                length++;
            }
            return length;
        }
        static void Main(string[] args)
        {
            string inputLine1 = Console.ReadLine(), inputLine2 = Console.ReadLine();
            string[] words1 = inputLine1.Split(), words2 = inputLine2.Split();
            Console.WriteLine(Math.Max(CommonStartLength(words1, words2), CommonEndLength(words1, words2)));
        }
    }
}
