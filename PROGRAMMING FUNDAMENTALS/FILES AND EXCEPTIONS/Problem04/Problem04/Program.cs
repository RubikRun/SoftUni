using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = File.ReadAllText("input.txt").Trim().Split().Select(int.Parse).ToArray();
            int currSeqStart = 0, currSeqLen=0, maxSeqStart=0, maxSeqLen=1;
            for (int i=0; i<nums.Length; i++)
            {
                currSeqLen++;
                if (i == nums.Length - 1 || nums[i] != nums[i+1])
                {
                    if (currSeqLen > maxSeqLen)
                    {
                        maxSeqLen = currSeqLen;
                        maxSeqStart = currSeqStart;
                    }
                    currSeqStart = i+1;
                    currSeqLen = 0;
                }
            }
            string outputLine = "";
            for (int i = 0; i < maxSeqLen; i++) outputLine += (nums[maxSeqStart].ToString()+" ");
            File.WriteAllText("output.txt", outputLine);
        }
    }
}
