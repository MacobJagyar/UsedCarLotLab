using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class UsedCar : Car 
    {

        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage) : 
            base(_make, _model, _year, _price) { Mileage = _mileage; }
        public double Mileage { get; set; }

        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "Make:", $"{Make}");
            string b = String.Format("\n{0,-10} {1, -10}", "Model:", $"{Model}");
            string c = String.Format("\n{0,-10} {1, -10}", "Year:", $"{Year}");
            string d = String.Format("\n{0,-10} {1, -10}", "Price:", $"${Price}");
            string e = String.Format("\n{0,-10} {1, -10}", "Mileage:", $"{Mileage}");
            return a + b + c + d + e;
        }

    }
}
