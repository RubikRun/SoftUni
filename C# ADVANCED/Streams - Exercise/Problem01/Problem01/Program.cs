using System;
using System.IO;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("text.txt"))
            {
                string line = String.Empty;
                for (int i = 0; line != null; i++)
                {
                    line = streamReader.ReadLine();
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
