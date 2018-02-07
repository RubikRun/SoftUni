using System;
using System.Collections.Generic;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);
            int length = input.Length;
            for (int i=0; i<length; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
