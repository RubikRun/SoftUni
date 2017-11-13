using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static string StringNumsSum(string num1, string num2)
        {
            List<int> result = new List<int>();
            int i = 0, carry=0, digit1, digit2;
            while (i < num1.Length || i < num2.Length || carry != 0)
            {
                digit1 = i < num1.Length ? num1[num1.Length - 1 - i] - '0' : 0;
                digit2 = i < num2.Length ? num2[num2.Length - 1 - i] - '0' : 0;
                result.Add(digit1 + digit2 + carry);
                carry = result.Last() / 10;
                result[result.Count - 1] %= 10;
                i++;
            }
            string resultString = "";
            result.Reverse();
            foreach (int digit in result)
            {
                resultString += (char)(digit + '0');
            }
            return resultString;
        }
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            Console.WriteLine(StringNumsSum(num1, num2));
        }
    }
}
