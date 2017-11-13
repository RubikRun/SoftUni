using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputLines = new List<string>();
            string[] phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(File.ReadAllText("input.txt").Trim());
            Random R = new Random((int)DateTime.Now.Ticks);
            for (int i=0; i<numberOfMessages; i++)
            {
                outputLines.Add(String.Format("{0} {1} {2} - {3}", phrases[R.Next(0, phrases.Length)],
                    events[R.Next(0, events.Length)], authors[R.Next(0, authors.Length)],
                    cities[R.Next(0, cities.Length)]));
            }
            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
