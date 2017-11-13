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
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine()), studioNight, doubleNight, suiteNight, studioDiscount = 0, doubleDiscount = 0, suiteDiscount = 0, studioFreeNights = 0;
            double studioPrice, doublePrice, suitePrice;

            if (month == "May" || month == "October")
            {
                studioNight = 50;
                doubleNight = 65;
                suiteNight = 75;
                if (nights > 7) studioDiscount = 5;
            }
            else if (month == "June" || month == "September")
            {
                studioNight = 60;
                doubleNight = 72;
                suiteNight = 82;
                if (nights > 14) doubleDiscount = 10;
            }
            else
            {
                studioNight = 68;
                doubleNight = 77;
                suiteNight = 89;
                if (nights > 14) suiteDiscount = 15;
            }
            if ((month == "September" || month == "October") && nights > 7) studioFreeNights = 1;

            studioPrice = (nights - studioFreeNights) * studioNight * (100 - studioDiscount) / 100.0;
            doublePrice = nights * doubleNight * (100 - doubleDiscount) / 100.0;
            suitePrice = nights * suiteNight * (100 - suiteDiscount) / 100.0;

            Console.WriteLine("Studio: {0} lv.", studioPrice.ToString("0.00"));
            Console.WriteLine("Double: {0} lv.", doublePrice.ToString("0.00"));
            Console.WriteLine("Suite: {0} lv.", suitePrice.ToString("0.00"));
        }
    }
}
