using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), max=0;
            Stack<int> stack = new Stack<int>();
            string input;
            for (int inputCounter = 0; inputCounter < n; inputCounter++)
            {
                input = Console.ReadLine();
                if (input[0] == '1')
                {
                    stack.Push(int.Parse(input.Substring(2)));
                    if (stack.Peek() > max)
                    {
                        max = stack.Peek();
                    }
                }
                else if (input[0] == '2')
                {
                    if (stack.Count > 0)
                    {
                        if (max == stack.Peek())
                        {
                            stack.Pop();
                            max = stack.Max();
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (input[0] == '3')
                {
                    Console.WriteLine(max);
                }
            }
        }
    }
}
