using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        class DataSet
        {
            public string name { get; set; }
            public List<string> keys { get; set; }
            public long size { get; set; }
            public bool exists { get; set; }
        }
        static void Main(string[] args)
        {
            List<DataSet> sets = new List<DataSet>();
            string commandLine = Console.ReadLine();
            string currKey;
            long currSize;
            string currSetName;
            while (commandLine != "thetinggoesskrra")
            {
                if (commandLine.Split('|').Count() == 2)
                {
                    currKey = commandLine.Split()[0];
                    currSize = long.Parse(commandLine.Split()[2]);
                    currSetName = commandLine.Split()[4];
                    if (sets.Where(x => x.name == currSetName).Count() == 1)
                    {
                        sets.Where(x => x.name == currSetName).First().size += currSize;
                        sets.Where(x => x.name == currSetName).First().keys.Add(currKey);
                    }
                    else
                    {
                        sets.Add(new DataSet { name = currSetName, keys = new List<string>(), size = currSize, exists = false });
                        sets.Last().keys.Add(currKey);
                    }
                }
                else
                {
                    if (sets.Where(x => x.name == commandLine).Count() == 1)
                    {
                        sets.Where(x => x.name == commandLine).First().exists = true;
                    }
                    else
                    {
                        sets.Add(new DataSet { name = commandLine, keys = new List<string>(), size = 0, exists = true });
                    }
                }
                commandLine = Console.ReadLine();
            }
            if (sets.Where(x => x.exists).Count() == 0)
            {
                return;
            }
            DataSet maxDataSet = sets.Where(x => x.exists).OrderBy(x => x.size).Last();
            Console.WriteLine("Data Set: {0}, Total Size: {1}", maxDataSet.name, maxDataSet.size);
            foreach (string key in maxDataSet.keys)
            {
                Console.WriteLine("$.{0}", key);
            }
        }
    }
}
