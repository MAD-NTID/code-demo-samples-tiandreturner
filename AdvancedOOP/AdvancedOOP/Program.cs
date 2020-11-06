using System;
using System.Collections.Generic;

namespace AdvancedOOP
{
    class Program
    {
        static List<Engine> engines = new List<Engine>();
        static void Main(string[] args)
        {
            string menu = String.Format("1. Build a car\n2. Add an engine\n3. Remove a car\n" +
                "4. List all cars\n5. List all engines\n6. Exit\n\nEnter your option: ");

            Car myCar;
            // Car[] cars = new Car[0]; // how to change this to list?
            List<Car> cars = new List<Car>();
           

            while (true)
            {
                Console.Write(menu);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        //Build a car
                        Console.Write("Enter the make of the car: ");
                        string make = Console.ReadLine();

                        Console.Write("Enter the model of the car: ");
                        string model = Console.ReadLine();

                        Console.Write("Enter the year of the car: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.Write("Enter the color of the car: ");
                        string color = Console.ReadLine();

                        Console.Write("Enter the type of the car: ");
                        string carType = Console.ReadLine();

                        Console.Write("Enter the gas tank capacity: ");
                        int gtc = int.Parse(Console.ReadLine());

                        Engine engine = null;
                        
                        DisplayEngines();

                        Console.Write("Select an engine: ");
                        engine = engines[int.Parse(Console.ReadLine()) - 1];

                        // create a new car object
                        myCar = new Car(make, model, year, color, carType, gtc, engine);

                       
                        cars.Add(myCar);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.Write("Number of cylinders: ");
                        int nc = int.Parse(Console.ReadLine());

                        Console.Write("Fuel Type: ");
                        string ft = Console.ReadLine();

                        Console.Write("Horsepower: ");
                        int hp = int.Parse(Console.ReadLine());

                        Console.Write("Engine Size (L): ");
                        double engSize = double.Parse(Console.ReadLine());

                        engines.Add(new Engine() { EngineSize = engSize, FuelType = ft, NumCylinders = nc, HorsePower = hp });
                        break;
                    case 3:
                        Console.Write($"Enter the number to remove a car (1 - {cars.Count}): ");

                        int choice = int.Parse(Console.ReadLine());

                        // how to remove a car object from list?
                        cars.RemoveAt(choice - 1); // OR cars.Remove(cars[choice - 1])
                        break;
                    case 4:
                        for (int i = 0; i < cars.Count; i++)
                        {
                            if (cars[i] == null)
                            {
                                Console.WriteLine("Empty Car");
                            }
                            else
                            {
                                Console.WriteLine(cars[i]);
                                Console.WriteLine("\n");
                            }

                        }
                        break;
                    case 5:
                        DisplayEngines();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void DisplayEngines()
        {
            int j = 1;
            foreach (Engine e in engines)
            {
                Console.WriteLine($"{j}. {e}");
                j++;
            }
        }
    }
}
