using System;
using System.Collections.Generic;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreen = int.Parse(Console.ReadLine()), carsPassed = 0, timeLeft;
            string input = Console.ReadLine();
            Queue<string> carsQueue = new Queue<string>();
            
            while (input != "end")
            {
                if (input == "green")
                {
                    timeLeft = carsPerGreen;
                    while (timeLeft > 0 && carsQueue.Count > 0)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsPassed++;
                        timeLeft--;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
