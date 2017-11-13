using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static double CalculateArea(string figureType, double length1, double length2 = 0)
        {
            if (figureType == "triangle") return length1 * length2 / 2;
            if (figureType == "square") return length1 * length1;
            if (figureType == "rectangle") return length1 * length2;
            if (figureType == "circle") return length1 * length1 * Math.PI;
            return -1;
        }
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "triangle" || figureType == "rectangle")
            {
                double length1 = double.Parse(Console.ReadLine());
                double length2 = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateArea(figureType, length1, length2).ToString("0.00"));
            }
            else
            {
                double length1 = double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateArea(figureType, length1).ToString("0.00"));
            }
        }
    }
}