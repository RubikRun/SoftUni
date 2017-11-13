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
            string profession = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            if (profession == "Athlete") Console.WriteLine("The Athlete has to pay " + (amount * 0.7).ToString("0.00") + ".");
            else if (profession == "Businessman" || profession == "Businesswoman") Console.WriteLine("The {0} has to pay {1}.", profession, amount.ToString("0.00"));
            else if (profession == "SoftUni Student") Console.WriteLine("The SoftUni Student has to pay " + (amount * 1.7).ToString("0.00") + ".");
            else Console.WriteLine("The {0} has to pay {1}.", profession, (amount * 1.2).ToString("0.00"));
        }
    }
}