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
            float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine());
            Console.WriteLine((a * b).ToString("0.00"));
        }
    }
}