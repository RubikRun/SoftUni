using System;

namespace Problem06
{
    class Program
    {
        static char[,] GetMatrixFromSnakeString(int rows, int cols, string snakeString)
        {
            int l = snakeString.Length;
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[rows - 1 - i, (1 - cols) * (i % 2 - 1) - j + 2 * j * (i % 2)] = snakeString[(i * cols + j) % l];
                }
            }
            return matrix;
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void ApplyShot(char[,] matrix, int shotRow, int shotCol, int shotRadius)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (shotRow < 0 || shotRow >= rows || shotCol < 0 || shotCol >= cols) return;

            for (int i = shotRow - shotRadius; i <= shotRow + shotRadius; i++)
            {
                for (int j = shotCol - shotRadius; j <= shotCol + shotRadius; j++)
                {
                    if ( (shotRow - i) * (shotRow - i) + (shotCol - j) * (shotCol - j) <= shotRadius * shotRadius)
                    {
                        if (i < 0 || i >= rows || j < 0 || j >= cols) continue;
                        matrix[i, j] = ' ';
                    }
                }
            }
        }

        static void ApplyGravity(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                for (int i = rows - 2; i >= 0; i--)
                {
                    if (matrix[i + 1, j] == ' ' && matrix[i, j] != ' ')
                    {
                        matrix[i + 1, j] = matrix[i, j];
                        matrix[i, j] = ' ';
                        if (i != rows - 2) i += 2;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);

            string snakeString = Console.ReadLine();

            inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int shotRow = int.Parse(inputs[0]);
            int shotCol = int.Parse(inputs[1]);
            int shotRadius = int.Parse(inputs[2]);


            char[,] matrix = GetMatrixFromSnakeString(rows, cols, snakeString);
            ApplyShot(matrix, shotRow, shotCol, shotRadius);
            ApplyGravity(matrix);
            PrintMatrix(matrix);
        }
    }
}
