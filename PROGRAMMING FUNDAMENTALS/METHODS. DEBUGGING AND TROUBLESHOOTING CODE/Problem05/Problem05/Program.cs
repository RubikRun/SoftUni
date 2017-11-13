using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static ulong Fib(int n)
        {
            if (n <= 1) return 1;
            ulong a = 1, b = 1, temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = b;
                b += a;
                a = temp;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
