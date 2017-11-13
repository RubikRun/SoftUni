using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static int CompareCharArrays (char[] arr1, char[] arr2)
        {
            for (int i=0; i<Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] != arr2[i])
                {
                    if (arr1[i] < arr2[i]) return 1;
                    else return -1;
                }
            }
            if (arr1.Length < arr2.Length) return 1;
            else if (arr1.Length > arr2.Length) return -1;
            return 0;
        }
        static void Main(string[] args)
        {
            string[] stringInputs1 = Console.ReadLine().Split(), stringInputs2 = Console.ReadLine().Split();
            int len1 = stringInputs1.Length, len2 = stringInputs2.Length;
            char[] arr1 = new char[len1], arr2 = new char[len2];
            for (int i=0; i<len1; i++) arr1[i] = (char)(stringInputs1[i][0]);
            for (int i=0; i<len2; i++) arr2[i] = (char)(stringInputs2[i][0]);

            int cmp = CompareCharArrays(arr1, arr2);
            if (cmp > 0)
            {
                for (int i = 0; i < len1; i++) Console.Write(arr1[i]);
                Console.WriteLine();
                for (int i = 0; i < len2; i++) Console.Write(arr2[i]);
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < len2; i++) Console.Write(arr2[i]);
                Console.WriteLine();
                for (int i = 0; i < len1; i++) Console.Write(arr1[i]);
                Console.WriteLine();
            }
        }
    }
}
