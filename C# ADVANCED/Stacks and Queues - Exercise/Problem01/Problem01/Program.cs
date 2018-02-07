using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            if (inputString == "") return;
            Stack<int> stack = new Stack<int>(inputString.Split().Select(x => int.Parse(x)));
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
