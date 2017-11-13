using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static double Calculate(double side, string wantedProperty)
        {
            if (wantedProperty == "face") return side*Math.Sqrt(2);
            if (wantedProperty == "space") return side*Math.Sqrt(3);
            if (wantedProperty == "volume") return side*side*side;
            if (wantedProperty == "area") return side*side*6;
            return -1;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string wantedProperty = Console.ReadLine();
            Console.WriteLine(Calculate(side, wantedProperty).ToString("0.00"));
        }
    }
}
