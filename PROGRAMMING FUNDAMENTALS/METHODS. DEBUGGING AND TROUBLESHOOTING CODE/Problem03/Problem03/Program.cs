using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static string digitName(char digit)
        {
            if (digit == '0') return "zero";
            if (digit == '1') return "one";
            if (digit == '2') return "two";
            if (digit == '3') return "three";
            if (digit == '4') return "four";
            if (digit == '5') return "five";
            if (digit == '6') return "six";
            if (digit == '7') return "seven";
            if (digit == '8') return "eight";
            if (digit == '9') return "nine";
            return "idk";
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(digitName(n.Last()));
        }
    }
}
