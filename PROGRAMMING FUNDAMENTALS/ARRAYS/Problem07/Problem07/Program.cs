using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int len = inputs.Length;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++) nums[i] = int.Parse(inputs[i]);

            int currSeqStart = 0, currSeqLen, maxSeqStart = 0, maxSeqLen = 1;
            for (int i = 1; i < len; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    currSeqLen = i - currSeqStart;
                    if (currSeqLen > maxSeqLen)
                    {
                        maxSeqLen = currSeqLen;
                        maxSeqStart = currSeqStart;
                    }
                    currSeqStart = i;
                }
            }
            currSeqLen = len - currSeqStart;
            if (currSeqLen > maxSeqLen)
            {
                maxSeqLen = currSeqLen;
                maxSeqStart = currSeqStart;
            }

            for (int i = maxSeqStart; true; i++)
            {
                Console.Write("{0} ", nums[i]);
                if (i >= len - 1) break;
                if (nums[i + 1] <= nums[i]) break;
            }
        }
    }
}
