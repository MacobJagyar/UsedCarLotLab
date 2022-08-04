using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class Car : CarLot
    {
        public Car(string aMake, string aModel, int aYear, decimal aPrice)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
            Price = aPrice;
        }

        public Car() { }

        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "Make:", $"{Make}");
            string b = String.Format("\n{0,-10} {1, -10}", "Model:", $"{Model}");
            string c = String.Format("\n{0,-10} {1, -10}", "Year:", $"{Year}");
            string d = String.Format("\n{0,-10} {1, -10}", "Price:", $"${Price}");
            return a + b + c + d;
        }


        //public virtual void PrintCarDetails(Car car)
        //{
        //    Console.WriteLine(String.Format("{0, -15} {1, -15}", "Make:", car.Make));
        //    Console.WriteLine(String.Format("{0, -15} {1, -15}", "Model:", car.Model));
        //    Console.WriteLine(String.Format("{0, -15} {1, -15}", "Year:", car.Year));
        //    Console.WriteLine(String.Format("{0, -15} {1, -15}", "Price:", car.Price));
        //}

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }



    }
}
