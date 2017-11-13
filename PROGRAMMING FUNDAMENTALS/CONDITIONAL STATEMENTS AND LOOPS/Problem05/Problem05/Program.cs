using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            char last = word.Last(), lastlast = word[word.Length - 2];

            for (int i = 0; i < word.Length - 1; i++) Console.Write(word[i]);
            if (last == 'y') Console.WriteLine("ies");
            else if (last == 'o' || last == 's' || last == 'x' || last == 'z' || (last == 'h' && (lastlast == 's' || lastlast == 'c'))) Console.WriteLine(last + "es");
            else Console.WriteLine(last + "s");
        }
    }
}
