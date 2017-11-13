using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsStrings = Console.ReadLine().Split();
            int len = numsStrings.Length, lastEl;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++) nums[i] = int.Parse(numsStrings[i]);
            int rotations = int.Parse(Console.ReadLine());

            int[] sums = new int[len];
            for (int i=0; i<rotations; i++)
            {
                lastEl = nums[len - 1];
                for (int j = len - 1; j > 0; j--) nums[j] = nums[j - 1];
                nums[0] = lastEl;
                for (int j = 0; j < len; j++) sums[j] += nums[j];
            }
            for (int i = 0; i < len; i++) Console.Write("{0} ", sums[i]);
        }
    }
}
