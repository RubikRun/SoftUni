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
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine()), maxS = int.Parse(Console.ReadLine()), s = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    s += 3 * i * j;
                    if (s >= maxS)
                    {
                        Console.WriteLine("{0} combinations", (n - i) * m + j);
                        Console.WriteLine("Sum: {0} >= {1}", s, maxS);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations", n * m);
            Console.WriteLine("Sum: {0}", s);
        }
    }
}
