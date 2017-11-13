using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        bool isEven(int n)
        {
            return (n % 2 == 0);
        }
        static void ApplyCommand(string command, List<int> nums)
        {
            List<string> commandParts = command.Split().ToList();
            if (commandParts[0] == "Delete")
            {
                int unwantedElementValue = int.Parse(commandParts[1]);
                for (int i=0; i<nums.Count; i++)
                {
                    if (nums[i] == unwantedElementValue)
                    {
                        nums.RemoveAt(i--);
                    }
                }
            }
            else if (commandParts[0] == "Insert")
            {
                int value = int.Parse(commandParts[1]), index = int.Parse(commandParts[2]);
                nums.Insert(index, value);
            }
        }
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string currCommand = Console.ReadLine();
            while (currCommand != "Even" && currCommand != "Odd")
            {
                ApplyCommand(currCommand, nums);
                currCommand = Console.ReadLine();
            }
            if (currCommand == "Even")
            {
                foreach (int element in nums)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write("{0} ", element);
                    }
                }
            }
            else
            {
                foreach (int element in nums)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write("{0} ", element);
                    }
                }
            }
        }
    }
}
