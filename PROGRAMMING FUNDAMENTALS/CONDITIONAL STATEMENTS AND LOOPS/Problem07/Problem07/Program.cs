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
            string ingredient = Console.ReadLine();
            int n = 0;
            while (ingredient != "Bake!")
            {
                n++;
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredient = Console.ReadLine();
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", n);
        }
    }
}
