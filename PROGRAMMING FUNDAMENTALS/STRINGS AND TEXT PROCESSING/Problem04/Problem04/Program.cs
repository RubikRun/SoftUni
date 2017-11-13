using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string str1 = inputs[0];
            string str2 = inputs[1];
            int num1, num2, sum=0;

            for (int i=0; i<Math.Max(str1.Length, str2.Length); i++)
            {
                num1 = i < str1.Length ? str1[i] : 1;
                num2 = i < str2.Length ? str2[i] : 1;
                sum += num1 * num2;
            }

            Console.WriteLine(sum);
        }
    }
}
