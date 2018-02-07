using System;
using System.Collections.Generic;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, n, x;
            string[] inputLineSplit = Console.ReadLine().Split();
            s = int.Parse(inputLineSplit[0]);
            n = int.Parse(inputLineSplit[1]);
            x = int.Parse(inputLineSplit[2]);
            inputLineSplit = Console.ReadLine().Split();
            Queue<int> queue = new Queue<int>();
            bool xFound = false;

            if (s - n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int smallest = int.Parse(inputLineSplit[inputLineSplit.Length - s + n]), currNum;
            for (int i = inputLineSplit.Length - s + n; i < inputLineSplit.Length; i++)
            {
                currNum = int.Parse(inputLineSplit[i]);
                queue.Enqueue(currNum);
                if (currNum == x)
                {
                    xFound = true;
                }
                else if (!xFound && currNum < smallest)
                {
                    smallest = currNum;
                }
            }
            if (xFound)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallest);
            }
        }
    }
}
