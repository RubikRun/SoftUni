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
            char a = char.Parse(Console.ReadLine()), b = char.Parse(Console.ReadLine()), x = char.Parse(Console.ReadLine());

            for (char i = a; i <= b; i++)
            {
                if (i == x) continue;
                for (char j = a; j <= b; j++)
                {
                    if (j == x) continue;
                    for (char k = a; k <= b; k++)
                    {
                        if (k == x) continue;
                        Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
        }
    }
}
