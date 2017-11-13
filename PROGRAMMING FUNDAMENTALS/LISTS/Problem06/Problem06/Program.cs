using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = inputArr[0], power = inputArr[1], start, end;

            for (int i=0; i<nums.Count; i++)
            {
                if (nums[i] == bombNumber)
                {
                    start = i - power;
                    end = i + power;
                    if (start < 0) start = 0;
                    if (end >= nums.Count) end = nums.Count - 1;
                    for (int j = 0; j < end - start + 1; j++)
                    {
                        nums.RemoveAt(start);
                    }
                    i -= power + 1;
                    if (i < 0) i = -1;
                }
            }

            int sum = 0;
            for (int i=0; i<nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
