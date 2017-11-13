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
            int currentHealth = int.Parse(Console.ReadLine()), maxHealth = int.Parse(Console.ReadLine()), currentEnergy = int.Parse(Console.ReadLine()), maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}\nHealth: |{1}|\nEnergy: |{2}|\n", name, new string('|', currentHealth) + new string('.', maxHealth - currentHealth), new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy));
        }
    }
}