using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static int GetCardValue(string card)
        {
            if (card.StartsWith("10"))
            {
                int t;
                if (card.Last() == 'C') t = 1;
                else if (card.Last() == 'D') t = 2;
                else if (card.Last() == 'H') t = 3;
                else t = 4;

                return 10 * t;
            }
            char power = card[0], type = card[1];
            int powerValue, typeValue;

            if (power == 'J') powerValue = 11;
            else if (power == 'Q') powerValue = 12;
            else if (power == 'K') powerValue = 13;
            else if (power == 'A') powerValue = 14;
            else powerValue = power - (int)'0';

            if (type == 'C') typeValue = 1;
            else if (type == 'D') typeValue = 2;
            else if (type == 'H') typeValue = 3;
            else typeValue = 4;

            return powerValue * typeValue;
        }
        static void Main(string[] args)
        {
            var peopleCards = new Dictionary<string, List<string>>();
            string currLine = Console.ReadLine(), currPerson="";
            List<string> currCards = new List<string>();
            while (currLine != "JOKER")
            {
                currPerson = currLine.Split(new []{":"}, StringSplitOptions.None)[0];
                currCards = currLine.Split(new[] { ": " }, StringSplitOptions.None)[1].Split(new[] { ", " }, StringSplitOptions.None).Distinct().ToList();
                if (peopleCards.ContainsKey(currPerson))
                {
                    foreach (var card in currCards)
                    {
                        if (!peopleCards[currPerson].Contains(card)) peopleCards[currPerson].Add(card);
                    }
                }
                else
                {
                    peopleCards[currPerson] = currCards;
                }
                currLine = Console.ReadLine();
            }

            foreach (var person in peopleCards)
            {
                Console.WriteLine("{0}: {1}", person.Key, person.Value.Select(x => GetCardValue(x)).Sum());
            }
        }
    }
}
