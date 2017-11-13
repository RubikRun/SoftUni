using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] frequency = new int[65536];

            string[] inputLine = Console.ReadLine().Split();
            int len = inputLine.Length;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++) nums[i] = int.Parse(inputLine[i]);
            int mostFrequenNumber = nums[0];

            for (int i=0; i<len; i++)
            {
                frequency[nums[i]]++;
                if (frequency[nums[i]] > frequency[mostFrequenNumber]) mostFrequenNumber = nums[i];
            }

            Console.WriteLine(mostFrequenNumber);
        }
    }
}
