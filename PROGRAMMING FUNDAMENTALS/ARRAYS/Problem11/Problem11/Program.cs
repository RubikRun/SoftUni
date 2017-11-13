using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int len = input.Length;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++) nums[i] = int.Parse(input[i]);

            int leftSum = 0, rightSum = 0;
            for (int i = 1; i < len; i++) rightSum += nums[i];
            if (leftSum == rightSum)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 1; i < len; i++)
            {
                leftSum += nums[i - 1];
                rightSum -= nums[i];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                if (leftSum > rightSum) break;
            }

            Console.WriteLine("no");
        }
    }
}
