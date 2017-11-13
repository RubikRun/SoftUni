using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int k = inputs.Length / 4;
            int[] nums = new int[4 * k];
            for (int i = 0; i < 4 * k; i++) nums[i] = int.Parse(inputs[i]);
            
            for (int i=0; i<k; i++) Console.Write("{0} ", nums[k + i] + nums[k - 1 - i]);
            for (int i = 0; i < k; i++) Console.Write("{0} ", nums[2 * k + i] + nums[4 * k - 1 - i]);
        }
    }
}
