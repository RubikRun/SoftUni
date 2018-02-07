using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var wordsReader = new StreamReader("words.txt"))
            {
                using (var textReader = new StreamReader("text.txt"))
                {
                    using (var resultWriter = new StreamWriter("result.txt"))
                    {
                        Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
                        string currWord = String.Empty;
                        while ((currWord = wordsReader.ReadLine()) != null)
                        {
                            wordsCounter[currWord] = 0;
                        }

                        string line = String.Empty;
                        string wordPattern = "[A-Za-z]+";
                        while ((line = textReader.ReadLine()) != null)
                        {
                            foreach (string word in Regex.Matches(line, wordPattern).Select(x => x.ToString()).Select(x => x.ToLower()))
                            {
                                if (wordsCounter.ContainsKey(word))
                                {
                                    wordsCounter[word]++;
                                }
                            }
                        }

                        List<KeyValuePair<string, int>> wordsFreqs = wordsCounter.ToList();
                        wordsFreqs = wordsFreqs.OrderByDescending(x => x.Value).ToList();

                        foreach (KeyValuePair<string, int> wordFreq in wordsFreqs)
                        {
                            resultWriter.WriteLine(wordFreq.Key + " - " + wordFreq.Value);
                        }
                    }
                }
            }
        }
    }
}
