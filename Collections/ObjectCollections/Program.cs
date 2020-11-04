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

            // insert new car in the list at position 1
            cars.Insert(1, new Car() { Make = "Chevrolet", Model = "Avalanche", Year = 2004 });

            Console.WriteLine("After inserting a new car!");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            // Removing a car from the list at position 2
            cars.RemoveAt(2);

            //Console.WriteLine("After removing a car by index!");
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //cars.Clear(); // remove all elements from the list

            //Console.WriteLine("After removing all cars!");
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            // Removing a car from the list using a value
            Car honda = new Car() { Make = "Honda" };
            cars.Add(honda);

            Console.WriteLine("After adding a new car!");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            cars.Remove(honda);

            //Console.WriteLine("After removing a car by value!");
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            // updating honda
            //Console.WriteLine("Which car do you want to update?: ");
            //string carMake = Console.ReadLine();
            //foreach(Car car in cars)
            //{
            //    if(car.Make == carMake)
            //    {
            //        Console.WriteLine("Update the make: ");
            //        car.Make = Console.ReadLine();

            //        Console.WriteLine("Update the Model: ");
            //        car.Model = Console.ReadLine();

            //        Console.WriteLine("Update the Year: ");
            //        car.Year = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //}

            //Console.WriteLine("After update a car!");
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //Console.WriteLine("Removing all fords!");
            // this is a buggy code for removing
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    if (cars[i].Make == "Ford")
            //    {
            //        cars.RemoveAt(i);
            //    }
            //}

            cars.Sort(CompareCars);
            Console.WriteLine("After sorting the cars list!");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            cars.Reverse();
            Console.WriteLine("After reversing the sorted cars list!");
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static int CompareCars(Car x, Car y)
        {
            return x.Year.CompareTo(y.Year);
            //return x.Make.CompareTo(y.Make);
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
