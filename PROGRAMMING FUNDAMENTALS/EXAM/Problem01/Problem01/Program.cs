using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01
{
    class Program
    {
        static BigInteger pow(byte a, byte b)
        {
            BigInteger r = 1;
            for (int i = 0; i < b; i++) r *= a;
            return r;
        }
        static void Main(string[] args)
        {
            byte sitesCount = byte.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());
            string[] sites = new string[sitesCount];
            uint[] visits = new uint[sitesCount];
            decimal[] prices = new decimal[sitesCount];
            decimal totalLoss = 0;
            string[] currSiteStringSplit;
            for (int i = 0; i < sitesCount; i++)
            {
                currSiteStringSplit = Console.ReadLine().Split();
                sites[i] = currSiteStringSplit[0];
                visits[i] = uint.Parse(currSiteStringSplit[1]);
                prices[i] = decimal.Parse(currSiteStringSplit[2]);
            }
            for (int i = 0; i < sitesCount; i++)
            {
                Console.WriteLine(sites[i]);
                totalLoss += visits[i] * prices[i];
            }
            Console.WriteLine("Total Loss: {0:0.00000000000000000000}", totalLoss);
            Console.WriteLine("Security Token: {0}", pow(securityKey, sitesCount));
        }
    }
}
