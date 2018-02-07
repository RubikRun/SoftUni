using System;
using System.Collections.Generic;

namespace Problem10
{
    class Program
    {
        class Player
        {
            public int hitPoints { get; set; }
            public double strength { get; set; }
            public int row { get; set; }
            public int col { get; set; }
            public int moveIndex { get; set; }
            public List<int> plagueDamageForDay { get; set; }
            public string killedBy { get; set; }

            public Player()
            {
                hitPoints = 18500; 
                strength = double.Parse(Console.ReadLine());
                row = 7;
                col = 7;
                moveIndex = 0;
                plagueDamageForDay = new List<int>();
                killedBy = "";
            }

            public void Attack(Heigan heigan)
            {
                heigan.hitPoints -= strength;
            }

            public bool IsWithinAttackRange(int row, int col)
            {
                return Math.Abs(this.row - row) <= 1 && Math.Abs(this.col - col) <= 1;
            }

            public void TryToEscapeAttack(int row, int col)
            {
                this.row--;
                if (this.row >= 0 && !IsWithinAttackRange(row, col)) return;
                this.row++;

                this.col++;
                if (this.col < 15 && !IsWithinAttackRange(row, col)) return;
                this.col--;

                this.row++;
                if (this.row < 15 && !IsWithinAttackRange(row, col)) return;
                this.row--;

                this.col--;
                if (this.col >= 0 && !IsWithinAttackRange(row, col)) return;
                this.col++;
            }

            public void TakeDamage(string spell)
            {
                if (spell == "Eruption")
                {
                    hitPoints -= 6000;
                    if (hitPoints < 0 && killedBy == "")
                    {
                        killedBy = spell;
                    }
                }
                else if (spell == "Cloud")
                {
                    plagueDamageForDay[moveIndex] += 3500;
                    if (moveIndex + 1 >= plagueDamageForDay.Count)
                    {
                        plagueDamageForDay.Add(3500);
                    }
                    else plagueDamageForDay[moveIndex + 1] += 3500;
                }
                else if (spell == "first")
                {
                    if (moveIndex >= plagueDamageForDay.Count)
                    {
                        plagueDamageForDay.Add(0);
                    }
                    else
                    {
                        hitPoints -= plagueDamageForDay[moveIndex];
                        if (hitPoints < 0 && killedBy == "") killedBy = "Plague Cloud";
                        plagueDamageForDay[moveIndex] = 0;
                    }
                }
                else
                {
                    hitPoints -= plagueDamageForDay[moveIndex];
                    if (hitPoints < 0 && killedBy == "") killedBy = "Plague Cloud";
                    moveIndex++;
                }
            }
        }

        class Heigan
        {
            public double hitPoints { get; set; }
            
            public Heigan()
            {
                hitPoints = 3000000;
            }

            public void Attack(Player player)
            {
                string[] attackComponents = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string spell = attackComponents[0];
                int row = int.Parse(attackComponents[1]);
                int col = int.Parse(attackComponents[2]);

                if (player.IsWithinAttackRange(row, col))
                {
                    player.TryToEscapeAttack(row, col);
                }
                if (player.IsWithinAttackRange(row, col))
                {
                    player.TakeDamage(spell);
                }
            }
        }

        static void ShowStats(Player player, Heigan heigan)
        {
            if (heigan.hitPoints < 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine("Heigan: {0:F2}", heigan.hitPoints);
            }
            if (player.hitPoints < 0)
            {
                Console.WriteLine($"Player: Killed by {player.killedBy}");
            }
            else
            {
                Console.WriteLine($"Player: {player.hitPoints}");
            }
            Console.WriteLine($"Final position: {player.row}, {player.col}");
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            Heigan heigan = new Heigan();

            while(heigan.hitPoints > 0 && player.hitPoints > 0)
            {
                player.Attack(heigan);
                player.TakeDamage("first");
                if (heigan.hitPoints < 0 || player.hitPoints < 0) break;
                heigan.Attack(player);
                player.TakeDamage("second");
            }

            ShowStats(player, heigan);
        }
    }
}
