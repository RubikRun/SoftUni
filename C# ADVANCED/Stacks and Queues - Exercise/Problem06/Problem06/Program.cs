using System;
using System.Collections.Generic;

namespace Problem06
{
    class Program
    {
        public class PetrolPupm
        {
            public int petrol { get; set; }
            public int distance { get; set; }
            public PetrolPupm (string inputLine)
            {
                petrol = int.Parse(inputLine.Split()[0]);
                distance = int.Parse(inputLine.Split()[1]);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPupm> petrolPumps = new Queue<PetrolPupm>();
            for (int i = 0; i < n; i++)
            {
                petrolPumps.Enqueue(new PetrolPupm(Console.ReadLine()));
            }

            for (int startIndex = 0; startIndex < n; startIndex++)
            {
                int fuel = 0;
                bool fullCircle = true;
                for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
                {
                    PetrolPupm currentPump = petrolPumps.Dequeue();
                    petrolPumps.Enqueue(currentPump);
                    fuel += currentPump.petrol - currentPump.distance;
                    if (fuel < 0)
                    {
                        fullCircle = false;
                        startIndex += pumpsPassed;
                        break;
                    }
                }
                if (fullCircle)
                {
                    Console.WriteLine(startIndex);
                    return;
                }
            }
        }
    } 
}
