using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem09
{
    class Program
    {
        static List<List<int>> InitPlane(int rows, int cols)
        {
            List<List<int>> plane = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> currRow = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    currRow.Add(i * cols + j + 1);
                }
                plane.Add(currRow);
            }
            return plane;
        }

        static void ApplyCommand(List<List<int>> plane, string command)
        {
            string[] commandComponents = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int row = int.Parse(commandComponents[0]);
            int col = int.Parse(commandComponents[1]);
            int radius = int.Parse(commandComponents[2]);

            List<int> numbersToRemove = new List<int>();
            
            for (int i = 0; i < plane.Count; i++)
            {
                numbersToRemove.Clear();
                for (int j = 0; j < plane[i].Count; j++)
                {
                    if ((i == row && Math.Abs(col - j) <= radius) || (j == col && Math.Abs(row - i) <= radius))
                    {
                        numbersToRemove.Add(plane[i][j]);
                    }
                }
                plane[i].RemoveAll(x => numbersToRemove.Contains(x));
            }
        }

        static void RemoveEmptyRows(List<List<int>> plane)
        {
            for (int i = 0; i < plane.Count; i++)
            {
                if (plane[i].Count == 0)
                {
                    plane.RemoveAt(i--);
                }
            }
        }
        static void PrintPlane(List<List<int>> plane)
        {
            for (int i = 0; i < plane.Count; i++)
            {
                for (int j = 0; j < plane[i].Count; j++)
                {
                    Console.Write(plane[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] inputs = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);
            List<List<int>> plane = InitPlane(rows, cols);

            while ((inputLine = Console.ReadLine()) != "Nuke it from orbit")
            {
                ApplyCommand(plane, inputLine);
                RemoveEmptyRows(plane);
            }

            PrintPlane(plane);
        }
    }
}
