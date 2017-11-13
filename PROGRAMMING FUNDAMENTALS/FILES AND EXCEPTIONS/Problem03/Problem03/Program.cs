using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem03
{
    class Program
    {
        static bool LeftRightSumsAreEqual(int[] nums, int index)
        {
            int leftSum = 0, rightSum = 0;
            for (int i = 0; i < index; i++) leftSum += nums[i];
            for (int i = index + 1; i < nums.Length; i++) rightSum += nums[i];
            return (leftSum == rightSum);
        }
        static void Main(string[] args)
        {
            int[] nums = File.ReadAllText("input.txt").Trim().Split().Select(int.Parse).ToArray();
            for (int i=0; i<nums.Length; i++)
            {
                if (LeftRightSumsAreEqual(nums, i))
                {
                    File.WriteAllText("output.txt", i.ToString());
                    return;
                }
            }
            File.WriteAllText("output.txt", "no");
        }
    }
}
