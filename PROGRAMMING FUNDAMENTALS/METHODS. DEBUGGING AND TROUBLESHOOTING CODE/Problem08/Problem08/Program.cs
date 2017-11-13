using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class Program
    {
        static double maxDouble(double a, double b)
        {
            if (a > b) return a;
            return b;
        }
        static double distance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine()), x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
            double d1 = distance(x1, y1), d2 = distance(x2, y2);
            if (d1 <= d2) Console.WriteLine("({0}, {1})", x1, y1);
            else Console.WriteLine("({0}, {1})", x2, y2);
        }
    }
}
