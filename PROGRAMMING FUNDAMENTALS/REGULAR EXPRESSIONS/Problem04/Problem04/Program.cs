using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem04
{
    class Program
    {
        class Forecast
        {
            public string city { get; set;}
            public double temperature { get; set; }
            public string weatherType { get; set; }
        }
        static void Main(string[] args)
        {
            string forecastPattern = @"(?<city>[A-Z]{2})(?<temperature>\d+\.\d+)(?<weatherType>[A-Za-z]+)\|";
            List<Forecast> forecasts = new List<Forecast>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                foreach(Match forecastMatch in Regex.Matches(inputLine, forecastPattern))
                {
                    forecasts.RemoveAll(x => x.city == forecastMatch.Groups["city"].Value);
                    forecasts.Add(new Forecast{
                        city = forecastMatch.Groups["city"].Value,
                        temperature = double.Parse(forecastMatch.Groups["temperature"].Value),
                        weatherType = forecastMatch.Groups["weatherType"].Value
                    });
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine(String.Join("\n", forecasts.OrderBy(x => x.temperature).Select(x => String.Format("{0} => {1:F2} => {2}", x.city, x.temperature, x.weatherType))));
        }
    }
}
