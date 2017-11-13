using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static bool isPrime(ulong n)
        {
            if (n <= 1) return false;
            for (ulong i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) return false; return true;
        }
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
