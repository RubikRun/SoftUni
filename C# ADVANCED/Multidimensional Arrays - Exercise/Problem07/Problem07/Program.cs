using System;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static int[][] ReadJaggedArray(int n)
        {
            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            return jaggedArray;
        }

        static bool CanFit(int[][] jaggedArray1, int[][] jaggedArray2)
        {
            int n = jaggedArray1.Length;
            int totalCols = jaggedArray1[0].Length + jaggedArray2[0].Length;
            for (int i = 1; i < n; i++)
            {
                if (jaggedArray1[i].Length + jaggedArray2[i].Length != totalCols)
                {
                    return false;
                }
            }
            return true;
        }

        static int[,] GetFitMatrix(int[][] jaggedArray1, int[][] jaggedArray2)
        {
            int rows = jaggedArray1.Length;
            int cols = jaggedArray1[0].Length + jaggedArray2[0].Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j < jaggedArray1[i].Length)
                    {
                        matrix[i, j] = jaggedArray1[i][j];
                    }
                    else
                    {
                        matrix[i, j] = jaggedArray2[i][jaggedArray2[i].Length - 1 - (j - jaggedArray1[i].Length)];
                    }
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine(matrix[i, matrix.GetLength(1) - 1] + "]");
            }
        }

        static int GetTotalNumberOfCells(int[][] jaggedArray)
        {
            int result = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                result += jaggedArray[i].Length;
            }
            return result;
        }

        static int GetTotalNumberOfCells(int[][] jaggedArray1, int[][] jaggedArray2)
        {
            return GetTotalNumberOfCells(jaggedArray1) + GetTotalNumberOfCells(jaggedArray2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray1 = ReadJaggedArray(n);
            int[][] jaggedArray2 = ReadJaggedArray(n);

            if (CanFit(jaggedArray1, jaggedArray2))
            {
                int[,] matrix = GetFitMatrix(jaggedArray1, jaggedArray2);
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {GetTotalNumberOfCells(jaggedArray1, jaggedArray2)}");
            }
        }
    }
}
