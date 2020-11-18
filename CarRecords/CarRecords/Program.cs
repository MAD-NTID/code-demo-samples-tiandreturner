using System;
using System.Collections.Generic;
using System.IO;

namespace CarRecords
{
    class Program
    {
        static List<Engine> engines = new List<Engine>();
        static void Main(string[] args)
        {
            string menu = String.Format("1. Build a car\n2. Add an engine\n3. Remove a car\n" +
                "4. List all cars\n5. List all engines\n6. Update Records\n7. Exit\n\nEnter your option: ");

            //6. Update Records
            Car myCar;
            // Car[] cars = new Car[0]; // how to change this to list?
            List<Car> cars = new List<Car>();

            string file = "carRecords.txt";

            // load data from a file into a car list
            LoadData(file, cars);


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
                        SaveRecords(file, cars);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static void SaveRecords(string file, List<Car> cars)
        {
            // how to write to a file???
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach(Car car in cars)
                {
                    sw.WriteLine(car.ToCSVFormat());
                }
            }

            Console.WriteLine("Records successfully updated!");
        }

        private static void LoadData(string file, List<Car> cars)
        {
            // If you want to check if a given file exist or not.
            if(File.Exists(file))
            {
                // how to read a file?
                // don't forget to include using.
                using (StreamReader sr = new StreamReader(file))
                {
                    string line = null;
                    string[] carData = null;
                    Engine engine = null;

                    // how to read each line from a file?
                    while((line = sr.ReadLine()) != null)
                    {
                        carData = line.Split(",");

                        // this is Object Initializer Sytnax
                        engine = new Engine()
                        {
                            EngineSize = double.Parse(carData[6]),
                            NumCylinders = int.Parse(carData[7]),
                            FuelType = carData[8],
                            HorsePower = int.Parse(carData[9])
                        };

                        cars.Add(new Car(carData[3], carData[4], 
                            int.Parse(carData[0]), carData[1], 
                            carData[5], int.Parse(carData[2]), engine));

                        if(engines.Count == 0)
                        {
                            engines.Add(engine);
                        }

                        // check for duplicate engine
                        bool engineFlag = false;

                        for(int i = 0; i < engines.Count; i++)
                        {
                            Engine e = engines[i];

                            if (e.EngineSize == engine.EngineSize && e.NumCylinders == engine.NumCylinders &&
                                e.FuelType == engine.FuelType && e.HorsePower == engine.HorsePower)
                            {
                                engineFlag = true;
                            }
                        }

                        if(!engineFlag)
                        {
                            engines.Add(engine);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File is not found");
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
