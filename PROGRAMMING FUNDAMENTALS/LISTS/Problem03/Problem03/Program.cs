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
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i=arr[1]; i<arr[0]; i++)
            {
                if (nums[i] == arr[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
