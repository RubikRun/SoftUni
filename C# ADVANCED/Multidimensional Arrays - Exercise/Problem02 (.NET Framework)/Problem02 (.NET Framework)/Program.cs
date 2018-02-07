using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02__.NET_Framework_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                string[] inputLineSplit = Console.ReadLine().Split().ToArray();
                sum1 += int.Parse(inputLineSplit[i]);
                sum2 += int.Parse(inputLineSplit[n - 1 - i]);
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
