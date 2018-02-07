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
            string[] inputs = Console.ReadLine().Split();
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);
            char[,] matrix = new char[rows, cols];
            int matriciesCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] row = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j][0];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i + 1, j] == matrix[i, j] && matrix[i, j + 1] == matrix[i, j] && matrix[i + 1, j + 1] == matrix[i, j])
                    {
                        matriciesCount++;
                    }
                }
            }

            Console.WriteLine(matriciesCount);
        }
    }
}
