using System;
using System.Collections.Generic;

namespace ObjectCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int number = 50; // variable initialization

            // What is OIS?
            // THIS IS OBJECT INITIALIZATION SYNTAX
            cars.Add(new Car() { Year = 2020, Make = "Chevrolet", Model = "Silverado" });
            cars.Add(new Car() { Year = 2013, Make = "Ford", Model = "Focus" });

            Car newCar = new Car();
            newCar.Year = 2000;
            newCar.Make = "Ford";
            newCar.Model = "F-150";

            cars.Add(newCar);

            //Car car1 = new Car(year, make, model);

            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }

    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return String.Format($"Year: {Year}\nMake: {Make}\nModel: {Model}\n");
        }
    }
}
