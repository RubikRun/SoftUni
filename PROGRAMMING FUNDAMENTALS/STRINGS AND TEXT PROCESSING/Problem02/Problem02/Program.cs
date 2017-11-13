using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem02
{
    class Program
    {
        static BigInteger ToBase10(int n, BigInteger num)
        {
            List<int> numDigits = new List<int>();
            while (num != 0)
            {
                numDigits.Add((int)(num % 10));
                num /= 10;
            }

            BigInteger result = 0;
            for (int i=numDigits.Count-1; i>=0; i--)
            {
                result *= n;
                result += numDigits[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            BigInteger num = BigInteger.Parse(inputs[1]);
            Console.WriteLine(ToBase10(n, num));
        }
    }
}
