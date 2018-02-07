using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, n, x, smallest;
            string[] inputs1 = Console.ReadLine().Split().ToArray();
            s = int.Parse(inputs1[0]);
            n = int.Parse(inputs1[1]);
            x = int.Parse(inputs1[2]);
            bool xFound = false;
            Stack<int> myStack = new Stack<int>();
            string[] inputs2 = Console.ReadLine().Split().ToArray();
            if (s - n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            smallest = int.Parse(inputs2[0]);
            for (int i=0; i<s-n; i++)
            {
                myStack.Push(int.Parse(inputs2[i]));
                if (myStack.Peek() == x)
                {
                    xFound = true;
                }
                else if (!xFound && myStack.Peek() < smallest)
                {
                    smallest = myStack.Peek();
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
