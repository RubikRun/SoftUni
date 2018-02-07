using System;
using System.Collections.Generic;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expressionParts = Console.ReadLine().Split();
            var stack = new Stack<string>();
            for (int i=expressionParts.Length-1; i>=0; i--)
            {
                stack.Push(expressionParts[i]);
            }
            while (stack.Count > 1)
            {
                int leftNumber = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int rightNumber = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    stack.Push((leftNumber + rightNumber).ToString());
                }
                else
                {
                    stack.Push((leftNumber - rightNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
