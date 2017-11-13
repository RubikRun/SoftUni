using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }
    }
}
