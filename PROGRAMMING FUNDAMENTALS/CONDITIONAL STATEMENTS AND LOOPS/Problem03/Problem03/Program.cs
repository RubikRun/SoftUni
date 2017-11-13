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
            int people = int.Parse(Console.ReadLine()), hallPrice = 7500, packagePrice = 1000, discount = 15;
            string package = Console.ReadLine();

            if (people <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                hallPrice = 2500;
            }
            else if (people <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                hallPrice = 5000;
            }
            else if (people <= 120) Console.WriteLine("We can offer you the Great Hall");
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 5;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 10;
            }

            Console.WriteLine("The price per person is {0}$", (((hallPrice + packagePrice) * (100 - discount) / 100.0) / people).ToString("0.00"));
        }
    }
}
