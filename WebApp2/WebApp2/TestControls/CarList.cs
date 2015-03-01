using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.TestControls
{
    public class CarList
    {
        private static List<Car> carList;

        public static void Initialize()
        {
            carList = Car.GetList();
        }

        public List<Car> Select()
        {
            return carList;
        }

        public void Update(Car updateCar)
        {
            Car carFound = carList.FirstOrDefault<Car>(c => c.Vin == updateCar.Vin);
            if (carFound == null)
                return;
            carFound.Make = updateCar.Make;
            carFound.Model = updateCar.Model;
            carFound.Year = updateCar.Year;
            carFound.Price = updateCar.Price;
        }

        public void Insert(Car car)
        {
            carList.Add(car);
        }

        public void Delete(Car deleteCar)
        {
            carList.RemoveAll(c => c.Vin == deleteCar.Vin);
        }

        public int Count()
        {
            return carList.Count;
        }
    }
}