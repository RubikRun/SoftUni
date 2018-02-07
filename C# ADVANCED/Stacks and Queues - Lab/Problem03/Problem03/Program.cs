using System;
using System.Collections.Generic;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            if (decimalNumber < 2)
            {
                Console.WriteLine(decimalNumber);
                return;
            }
            Stack<int> binaryDigits = new Stack<int>();
            while (decimalNumber > 0)
            {
                binaryDigits.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }
            while (binaryDigits.Count > 0)
            {
                Console.Write(binaryDigits.Pop());
            }
            Console.WriteLine();
        }
    }
}
