﻿using System;
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
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            if (b - a < 4) Console.WriteLine("No");
            else for (int n1 = a; n1 <= b - 4; n1++) for (int n2 = n1 + 1; n2 <= b - 3; n2++) for (int n3 = n2 + 1; n3 <= b - 2; n3++)
                            for (int n4 = n3 + 1; n4 <= b - 1; n4++) for (int n5 = n4 + 1; n5 <= b; n5++) Console.WriteLine("{0} {1} {2} {3} {4}", n1, n2, n3, n4, n5);
        }
    }
}
