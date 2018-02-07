using System;
using System.Collections.Generic;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openBracketsIndexes = new Stack<int>();
            int currentSubstringLength;
            for (int i=0; i<input.Length; i++)
            {
                if (input[i]=='(')
                {
                    openBracketsIndexes.Push(i);
                }
                else if (input[i]==')')
                {
                    currentSubstringLength = i - openBracketsIndexes.Peek() + 1;
                    Console.WriteLine(input.Substring(openBracketsIndexes.Pop(), currentSubstringLength));
                }
            }
        }
    }
}
