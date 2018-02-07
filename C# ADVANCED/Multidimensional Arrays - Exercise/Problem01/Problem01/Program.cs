using System;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[] inputs = Console.ReadLine().Split();
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);
            string[,] matrix = new string[rows, cols];

            for (int currRow = 0; currRow < rows; currRow++)
            {
                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[currRow, currCol] = alphabet[currRow].ToString() + alphabet[currRow + currCol].ToString() + alphabet[currRow].ToString();
                }
            }

            for (int currRow = 0; currRow < rows; currRow++)
            {
                for (int currCol = 0; currCol < cols; currCol++)
                {
                    Console.Write(matrix[currRow, currCol] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
