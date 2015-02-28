using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.TestControls
{
    public class Car
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car(string vin, string make, string model, int year, decimal price)
        {
            Vin = vin;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public static List<Car> GetList()
        {
            List<Car> carList = new List<Car>();
            carList.Add(new Car("1A59B", "Chevrolet", "Impala", 1963, 1125.00M));
            carList.Add(new Car("9B25T", "Ford", "F-250", 1970, 1595.00M));
            carList.Add(new Car("3H13R", "BMW", "Z4", 2006, 55123.00M));
            carList.Add(new Car("7D67A", "Mazda", "Miata", 2003, 28250.00M));
            carList.Add(new Car("4T21N", "Volkswagen", "Beetle", 1956, 500.00M));
            return carList;
        }
    }
}