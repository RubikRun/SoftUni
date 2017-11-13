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
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), swap;
            if (a > b)
            {
                swap = a;
                a = b;
                b = swap;
            }

            while (a <= b) Console.WriteLine(a++);
        }
    }
}
