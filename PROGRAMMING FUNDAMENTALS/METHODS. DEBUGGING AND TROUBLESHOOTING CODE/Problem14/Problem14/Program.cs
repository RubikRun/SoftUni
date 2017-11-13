using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static int zerosFactorialEnd(int n)
        {
            int zeros = 0, power = 5;
            while (power <= n)
            {
                zeros += n / power;
                power *= 5;
            }
            return zeros;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(zerosFactorialEnd(n));
        }
    }
}
