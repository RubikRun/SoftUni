using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static string reversed(string s)
        {
            string r = "";
            for (int i = s.Length - 1; i >= 0; i--) r += s[i];
            return r;
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(reversed(n));
        }
    }
}
