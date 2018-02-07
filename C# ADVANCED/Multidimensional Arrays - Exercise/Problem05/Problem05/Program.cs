using System;

namespace Problem05
{
    class Program
    {
        static int[] GetCoordinates(int[,] matrix, int a)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == a)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        static void FixAndTell(int[,] matrix)
        {
            int shouldBe = 1, temp=0;
            int[] coordinates = new int[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == shouldBe)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        coordinates = GetCoordinates(matrix, shouldBe);
                        temp = matrix[i, j];
                        matrix[i, j] = shouldBe;
                        matrix[coordinates[0], coordinates[1]] = temp;
                        Console.WriteLine($"Swap ({i}, {j}) with ({coordinates[0]}, {coordinates[1]})");
                    }
                    shouldBe++;
                }
            }
        }

        static void RotateRow(int[,] matrix, int row, int change, int moves)
        {
            int m = matrix.GetLength(1);
            moves = moves % m;
            int[] originalRow = new int[m];
            for (int i = 0; i < m; i++) originalRow[i] = matrix[row, i];

            for (int i = 0; i < m; i++)
            {
                int index = i - change * moves;
                if (index < 0) index += m;
                else if (index >= m) index -= m;
                matrix[row, i] = originalRow[index];
            }
        }

        static void RotateCol(int[,] matrix, int col, int change, int moves)
        {
            int n = matrix.GetLength(0);
            moves = moves % n;
            int[] originalCol = new int[n];
            for (int i = 0; i < n; i++) originalCol[i] = matrix[i, col];

            for (int i = 0; i < n; i++)
            {
                int index = i - change * moves;
                if (index < 0) index += n;
                else if (index >= n) index -= n;
                matrix[i, col] = originalCol[index];
            }
        }

        static void ApplyCommand(int[,] matrix, string command)
        {
            string[] commandSplit = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rowColIndex = int.Parse(commandSplit[0]);
            int changePerMove = 1;
            if (commandSplit[1] == "left" || commandSplit[1] == "up") changePerMove = -1;
            int moves = int.Parse(commandSplit[2]);

            if (commandSplit[1] == "left" || commandSplit[1] == "right")
            {
                RotateRow(matrix, rowColIndex, changePerMove, moves);
            }
            else
            {
                RotateCol(matrix, rowColIndex, changePerMove, moves);
            }
        }
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int rows = int.Parse(inputLine.Split()[0]);
            int cols = int.Parse(inputLine.Split()[1]);
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = i * cols + j + 1;
                }
            }
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();
                ApplyCommand(matrix, inputLine);
            }
            FixAndTell(matrix);
        }
    }
}
