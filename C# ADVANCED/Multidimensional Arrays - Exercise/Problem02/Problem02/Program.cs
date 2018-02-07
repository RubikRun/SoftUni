using System;
using System.Linq;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum1 += currRow[j];
                    }
                    if (i == n - 1 - j)
                    {
                        sum2 += currRow[j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
