using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            Stack<char> parentheses = new Stack<char>();

            for (int i=0; i<input.Length; i++)
            {
                switch (input[i])
                {
                    case '(': parentheses.Push('('); break;
                    case '[': parentheses.Push('['); break;
                    case '{': parentheses.Push('{'); break;
                    case ')':
                        if (parentheses.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        break;
                    case ']':
                        if (parentheses.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        break;
                    case '}':
                        if (parentheses.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        break;
                }
            }

            if (parentheses.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}