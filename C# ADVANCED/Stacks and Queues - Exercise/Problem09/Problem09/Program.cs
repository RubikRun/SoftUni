using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine(1);
                Environment.Exit(0);
            }

            long a = 1, b = 1, c = a + b;

            for (long i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine(c);
        }
    }
}
