using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static int GetReversedNumber(int n)
        {
            int reversedNumber = 0;
            while (n != 0)
            {
                reversedNumber *= 10;
                reversedNumber += n % 10;
                n /= 10;
            }
            return reversedNumber;
        }
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            for (int i=0; i<nums.Count; i++)
            {
                sum += GetReversedNumber(nums[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
