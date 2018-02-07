using System;
using System.IO;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("text.txt"))
            {
                using (var streamWriter = new StreamWriter("output.txt"))
                {
                    string line = String.Empty;
                    for (int i = 1; line != null; i++)
                    {
                        line = streamReader.ReadLine();
                        streamWriter.WriteLine("Line " + i + ": " + line);
                    }
                }
            }
        }
    }
}
