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
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine()), energy = int.Parse(Console.ReadLine()), sugar = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, energy * volume / 100.0, sugar * volume / 100.0);
        }
    }
}