using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine()), t = int.Parse(Console.ReadLine());

            if (2 * m < t || 2 * n > t)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", (m - n + 1) * (m - n + 1), t);
                return;
            }
            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    if (i + j == t)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", i, j, t);
                        return;
                    }
                }
            }
        }
    }
}
