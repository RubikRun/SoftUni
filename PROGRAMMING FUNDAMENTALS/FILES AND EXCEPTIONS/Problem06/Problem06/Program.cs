using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            List<string> outputLines = new List<string>();

            var peopleEmails = new Dictionary<string, string>();
            string currentName = "", currentEmail = "", currentLine;
            for (int i = 0; true; i++)
            {
                currentLine = inputLines[i];
                if (currentLine == "stop") break;
                if (i % 2 == 0)
                {
                    currentName = currentLine;
                }
                else
                {
                    currentEmail = currentLine;
                    if (!(currentEmail.ToLower().EndsWith("us") || currentEmail.ToLower().EndsWith("uk")))
                    {
                        peopleEmails[currentName] = currentEmail;
                    }
                }
            }

            foreach (var person in peopleEmails)
            {
                outputLines.Add(String.Format("{0} -> {1}", person.Key, person.Value));
            }
            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
