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
            int peshoDamage = int.Parse(Console.ReadLine()), goshoDamage = int.Parse(Console.ReadLine()), peshoHealth = 100, goshoHealth = 100;

            for (int round = 1; true; round++)
            {
                if (round % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", round);
                        return;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);

                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", round);
                        return;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
