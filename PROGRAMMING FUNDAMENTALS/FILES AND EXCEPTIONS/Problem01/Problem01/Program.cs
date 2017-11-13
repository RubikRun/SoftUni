using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            int maxFrequency = 1;
            foreach(int num in nums)
            {
                if (frequencies.ContainsKey(num))
                {
                    frequencies[num]++;
                    if (frequencies[num] > maxFrequency) maxFrequency = frequencies[num];
                }
                else frequencies[num] = 1;
            }
            foreach(var frequency in frequencies)
            {
                if (frequency.Value == maxFrequency)
                {
                    File.WriteAllText("output.txt", frequency.Key.ToString());
                    return;
                }
            }
        }
    }
}
