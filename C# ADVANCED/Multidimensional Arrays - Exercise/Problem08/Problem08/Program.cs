using System;
using System.Collections.Generic;

namespace Problem08
{
    class Program
    {
        class Player
        {
            public int row { get; set; }
            public int col { get; set; }
            public int prevRow { get; set; }
            public int prevCol { get; set; }
            public bool isAlive { get; set; }
            public Player (int row, int col)
            {
                this.row = row;
                this.col = col;
                this.isAlive = true;
            }
            public bool Escaped(char[,] lair)
            {
                return row < 0 || row >= lair.GetLength(0) || col < 0 || col >= lair.GetLength(1);
            }
        };

        static char[,] ReadLair(int n, int m)
        {
            char[,] lair = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    lair[i, j] = currRow[j];
                }
            }

            return lair;
        }

        static Player InitPlayer(char[,] lair)
        {
            for (int i = 0; i < lair.GetLength(0); i++)
            {
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    if (lair[i, j] == 'P')
                    {
                        return new Player(i, j);
                    }
                }
            }
            return new Player(-1, -1);
        }

        static void MakePlayersMove(char[,] lair, Player player, char move)
        {
            int rowChange = 0;
            int colChange = 0;
            switch(move)
            {
                case 'R': colChange = 1; break;
                case 'U': rowChange = -1; break;
                case 'L': colChange = -1; break;
                case 'D': rowChange = 1; break;
            }

            player.prevRow = player.row;
            player.prevCol = player.col;
            player.row = player.row + rowChange;
            player.col = player.col + colChange;

            lair[player.prevRow, player.prevCol] = '.';
            if (!player.Escaped(lair))
            {
                if (lair[player.row, player.col] == 'B') player.isAlive = false;
                else lair[player.row, player.col] = 'P';
            }
        }

        static void AddNewBunniesToList(char[,] lair, int n, int m, List<int[]> newBunniesList)
        {
            if (n - 1 >= 0 && n - 1 < lair.GetLength(0) && lair[n - 1, m] != 'B')
            {
                newBunniesList.Add(new int[] { n - 1, m });
            }
            if (n + 1 >= 0 && n + 1 < lair.GetLength(0) && lair[n + 1, m] != 'B')
            {
                newBunniesList.Add(new int[] { n + 1, m });
            }
            if (m - 1 >= 0 && m - 1 < lair.GetLength(1) && lair[n, m - 1] != 'B')
            {
                newBunniesList.Add(new int[] { n, m - 1 });
            }
            if (m + 1 >= 0 && m + 1 < lair.GetLength(1) && lair[n, m + 1] != 'B')
            {
                newBunniesList.Add(new int[] { n, m + 1 });
            }
        }
        static void LetBunniesMultiply(char[,] lair, Player player)
        {
            List<int[]> newBunniesList = new List<int[]>();

            for (int i = 0; i < lair.GetLength(0); i++)
            {
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    if (lair[i, j] == 'B')
                        AddNewBunniesToList(lair, i, j, newBunniesList);
                }
            }
            foreach (int[] bunny in newBunniesList)
            {
                if (bunny[0] == player.row && bunny[1] == player.col) player.isAlive = false;
                lair[bunny[0], bunny[1]] = 'B';
            }
        }

        static void PrintLair(char[,] lair)
        {
            for (int i = 0; i < lair.GetLength(0); i++)
            {
                for (int j = 0; j < lair.GetLength(1); j++)
                {
                    Console.Write(lair[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            char[,] lair = ReadLair(n, m);
            Player player = InitPlayer(lair);
            string moves = Console.ReadLine();

            for (int i = 0; i < moves.Length; i++)
            {
                MakePlayersMove(lair, player, moves[i]);
                LetBunniesMultiply(lair, player);
                if (!player.isAlive)
                {
                    PrintLair(lair);
                    Console.WriteLine($"dead: {player.row} {player.col}");
                    break;
                }
                else if (player.Escaped(lair))
                {
                    PrintLair(lair);
                    Console.WriteLine($"won: {player.prevRow} {player.prevCol}");
                    break;
                }
            }
        }
    }
}
