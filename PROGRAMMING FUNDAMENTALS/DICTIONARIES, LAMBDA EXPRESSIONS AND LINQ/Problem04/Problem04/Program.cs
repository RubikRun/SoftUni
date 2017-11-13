using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleEmails = new Dictionary<string, string>();
            string currentName = "", currentEmail = "", currentLine;
            for (int i=0; true; i++)
            {
                currentLine = Console.ReadLine();
                if (currentLine == "stop") break;
                if (i%2 == 0)
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

            foreach(var person in peopleEmails)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
