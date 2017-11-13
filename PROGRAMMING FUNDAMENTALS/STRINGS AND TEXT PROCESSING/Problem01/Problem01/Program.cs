using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01
{
    class Program
    {
        static BigInteger Base10ToBaseN(int n, BigInteger num)
        {
            List<int> resultDigits = new List<int>();
            while (num != 0)
            {
                resultDigits.Add((int)(num % n));
                num /= n;
            }

            BigInteger result = 0;
            for (int i=resultDigits.Count-1; i>=0; i--)
            {
                result *= 10;
                result += resultDigits[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            BigInteger num = BigInteger.Parse(inputs[1]);
            Console.WriteLine(Base10ToBaseN(n, num));
        }
    }
}
