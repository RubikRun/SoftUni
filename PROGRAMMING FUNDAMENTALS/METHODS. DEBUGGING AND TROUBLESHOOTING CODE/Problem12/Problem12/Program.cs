using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static bool NumIsPalindrome(int n)
        {
            string s = n.ToString();
            int l = s.Length;
            for (int i = 0; i < l / 2; i++) if (s[i] != s[l - 1 - i]) return false;
            return true;
        }
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static bool HasAnEvenDigit(int n)
        {
            while (n != 0)
            {
                if (n % 2 == 0) return true;
                n /= 10;
            }
            return false;
        }
        static bool isMasterNumber(int n)
        {
            return NumIsPalindrome(n) && (SumOfDigits(n) % 7 == 0) && HasAnEvenDigit(n);
        }
        static void PrintMasterNumbers(int end)
        {
            for (int i = 1; i <= end; i++) if (isMasterNumber(i)) Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            PrintMasterNumbers(end);
        }
    }
}
