using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int len = inputs.Length;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++) nums[i] = int.Parse(inputs[i]);
            int dif = int.Parse(Console.ReadLine());
            int numberOfPairs = 0;

            for (int i=0; i<len-1; i++)
            {
                for (int j=i+1; j<len; j++)
                {
                    if (nums[i] - nums[j] == dif || nums[j] - nums[i] == dif) numberOfPairs++;
                }
            }

            Console.WriteLine(numberOfPairs);
        }
    }
}
