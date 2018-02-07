﻿using System;

namespace Problem08
{
    class Program
    {
        static long Fib(int n)
        {
            if (n <= 0) return 0;
            if (n <= 2) return 1;
            return Fib(n - 3) + 2 * Fib(n - 2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
