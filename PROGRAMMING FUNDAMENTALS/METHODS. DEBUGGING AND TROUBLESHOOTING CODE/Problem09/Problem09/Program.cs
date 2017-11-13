using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Program
    {
        static double distance(double x, double y)
        {
            return Math.Sqrt(x*x+y*y);
        }
        static double lineLength(double[] line)
        {
            return Math.Sqrt((line[0]-line[2])*(line[0]-line[2])+(line[1]-line[3])*(line[1]-line[3]));
        }
        static double[] longerLine(double[] line1, double[] line2)
        {
            if (lineLength(line1) >= lineLength(line2)) return line1;
            return line2;
        }
        static string lineString(double[] line)
        {
            if (distance(line[0], line[1]) <= distance(line[2], line[3])) return String.Format("({0}, {1})({2}, {3})", line[0], line[1], line[2], line[3]);
            return String.Format("({0}, {1})({2}, {3})", line[2], line[3], line[0], line[1]);
        }
        static void Main(string[] args)
        {
            double[] line1 = new double[4], line2 = new double[4];
            for (int i = 0; i < 4; i++) line1[i] = double.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++) line2[i] = double.Parse(Console.ReadLine());
            Console.WriteLine(lineString(longerLine(line1, line2)));
        }
    }
}
