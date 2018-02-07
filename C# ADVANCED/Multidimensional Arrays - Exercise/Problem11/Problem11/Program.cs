using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem11
{
    class Program
    {
        class Car
        {
            public int row { get; set; }
            public int col { get; set; }
            public int beginRow { get; set; }
            public bool foundItsPlace { get; set; }
            public int GetDistance()
            {
                return col + row - beginRow + 1;
            }
            public Car(string str)
            {
                string[] parameters = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                beginRow = int.Parse(parameters[0]);
                row = int.Parse(parameters[1]);
                col = int.Parse(parameters[2]);
                foundItsPlace = true;
            }
        }

        static bool CarColCompareFunction(Car car1, Car car2)
        {
            return car1.col == car2.col;
        }
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] inputs = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);
            int moveTo = 0;

            List<Car>[] parking = new List<Car>[rows];
            for (int i = 0; i < rows; i++) parking[i] = new List<Car>();

            List<Car> cars = new List<Car>();
            Car car;

            while ((inputLine = Console.ReadLine()) != "stop")
            {
                car = new Car(inputLine);
                moveTo = 0;
                if (parking[car.row].Count < cols - 1)
                {
                    while (parking[car.row].Any(x => x.col == car.col + moveTo))
                    {
                        if (moveTo < 0)
                        {
                            if (car.col - moveTo < cols) moveTo = -moveTo;
                            else moveTo--;
                        }
                        else
                        {
                            if (car.col - moveTo - 1 > 0) moveTo = -moveTo - 1;
                            else moveTo++;
                        }
                    }
                    car.col += moveTo;
                    parking[car.row].Add(car);
                }
                else
                {
                    car.foundItsPlace = false;
                }
                cars.Add(car);
            }

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].foundItsPlace)
                {
                    Console.WriteLine(cars[i].GetDistance());
                }
                else
                {
                    Console.WriteLine($"Row {cars[i].row} full");
                }
            }
        }
    }
}
