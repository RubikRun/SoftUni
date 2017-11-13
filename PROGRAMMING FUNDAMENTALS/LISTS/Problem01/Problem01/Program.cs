using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currSeqBegin=0, currSeqEnd, currSeqLen, maxSeqBegin=0, maxSeqLen=0;
            for (int i=0; i<nums.Count-1; i++)
            {
                if (nums[i] != nums[i+1])
                {
                    currSeqEnd = i;
                    currSeqLen = currSeqEnd - currSeqBegin + 1;
                    if (currSeqLen > maxSeqLen)
                    {
                        maxSeqLen = currSeqLen;
                        maxSeqBegin = currSeqBegin;
                    }
                    currSeqBegin = i + 1;
                }
            }
            currSeqEnd = nums.Count - 1;
            currSeqLen = currSeqEnd - currSeqBegin + 1;
            if (currSeqLen > maxSeqLen)
            {
                maxSeqLen = currSeqLen;
                maxSeqBegin = currSeqBegin;
            }
            for (int i = 0; i < maxSeqLen; i++) Console.Write("{0} ", nums[maxSeqBegin]);
        }
    }
}
