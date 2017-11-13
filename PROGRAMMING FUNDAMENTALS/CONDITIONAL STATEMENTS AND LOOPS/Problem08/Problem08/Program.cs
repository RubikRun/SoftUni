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
            int n = int.Parse(Console.ReadLine()), calories = 0;
            string ingredient;
            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine();
                if (ingredient.ToLower() == "cheese") calories += 500;
                else if (ingredient.ToLower() == "tomato sauce") calories += 150;
                else if (ingredient.ToLower() == "salami") calories += 600;
                else if (ingredient.ToLower() == "pepper") calories += 50;
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
