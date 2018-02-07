using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Queue<BigInteger> queue = new Queue<BigInteger>();
            queue.Enqueue(n);
            
            for (int i=2; i<=50; i++)
            {
                if (i % 3 == 0)
                {
                    queue.Enqueue(2 * queue.Peek() + 1);
                }
                else if (i % 3 == 1)
                {
                    queue.Enqueue(queue.Peek() + 2);
                    Console.Write(queue.Dequeue() + " ");
                }
                else
                {
                    queue.Enqueue(queue.Peek() + 1);
                }
            }
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
