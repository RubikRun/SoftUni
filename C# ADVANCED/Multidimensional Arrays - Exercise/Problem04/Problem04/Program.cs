using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            int n = int.Parse(firstLine.Split()[0]);
            int m = int.Parse(firstLine.Split()[1]);
            int[,] matrix = new int[n, m];
            int maxSum = int.MinValue, currSum = 0, maxSumRow = 0, maxSumCol = 0;
            
            for (int i = 0; i < n; i++)
            {
                string[] numbersAsStrings = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(numbersAsStrings[j]);
                }
            }

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    currSum = 0;
                    for (int a = 0; a < 3; a++)
                    {
                        for (int b = 0; b < 3; b++)
                        {
                            currSum += matrix[i + a, j + b];
                        }
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumRow = i;
                        maxSumCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write(matrix[maxSumRow + a, maxSumCol + b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
