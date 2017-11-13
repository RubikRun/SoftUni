using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n+1];
            for (int i = 0; i < n + 1; i++) isPrime[i] = true;

            for (int i = 2; i < n + 1; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i*i; j < n + 1; j+=i) isPrime[j] = false;
            }

            for (int i = 2; i <= n; i++) if (isPrime[i]) Console.Write("{0} ", i);
        }
    }
}
