using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class CarLot
    {

        public static void RemoveCar(List<Car> carList, Car carA)
        {
            carList.Remove(carA);
        }


        public static void PrintAllCars(List<Car>carList, int selectionNum)
        {
            foreach (Car car in carList)
            {
                Console.WriteLine($"\nSELECTION #{selectionNum}");
                Console.WriteLine(car.ToString());
                selectionNum++;
            }

            selectionNum = 1;
        }

        public static void AddCar( List<Car> carList, UsedCar carA )
        {
            Console.WriteLine("Tell us about your car! ");
            Console.WriteLine("\nMake? ");
            carA.Make = Console.ReadLine().ToLower();

            Console.WriteLine("\nModel?");
            carA.Model = Console.ReadLine();

            Console.WriteLine("\nYear?");
            carA.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMiles?");
            carA.Mileage = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's the resale value?");
            carA.Price = decimal.Parse(Console.ReadLine());

            carList.Add(carA);

        }
    }
}
