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
    }
}
