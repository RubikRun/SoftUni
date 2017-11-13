using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    n++;
                }
                catch
                {
                    break;
                }
            }
            Console.WriteLine(n);
        }
    }
}
