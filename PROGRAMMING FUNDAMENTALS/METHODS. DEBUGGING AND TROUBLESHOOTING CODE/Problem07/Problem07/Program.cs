using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Program
    {
        static List<int> primesInRangeList(int first, int last)
        {
            List<int> list = new List<int>();
            for (int num = first; num <= last; num++) if (isPrime(num)) list.Add(num);
            return list;
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return (n == 2);
            for (int i = 3; i <= Math.Sqrt(n); i += 2) if (n % i == 0) return false; return true;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            List<int> list = primesInRangeList(a, b);
            for (int i = 0; i < list.Count - 1; i++) Console.Write("{0}, ", list[i]);
            Console.WriteLine(list.Last());
        }
    }
}
