using System;
using System.Collections.Generic;

namespace CarDictionary
{
    class Program
    {
        static List<Engine> engines = new List<Engine>();
        static void Main(string[] args)
        {
            string menu = String.Format("1. Build a car\n2. Add an engine\n3. Remove a car\n4. Search for car\n5. Selling a car\n" +
                "6. Search for sold cars\n7. List all cars\n8. List all engines\n9. Exit\n\nEnter your option: ");

            Car myCar;
            // Car[] cars = new Car[0]; // how to change this to list?
            // List<Car> cars = new List<Car>();

            Dictionary<string, Car> carDict = new Dictionary<string, Car>(); // Create a Dictionary object
            Dictionary<string, Car> soldDict = new Dictionary<string, Car>();

            // build engines
            engines.Add(new Engine() { EngineSize = 2.0, FuelType = "Gas", HorsePower = 180, NumCylinders = 4 });
            engines.Add(new Engine() { EngineSize = 3.5, FuelType = "Gas", HorsePower = 290, NumCylinders = 6 });
            engines.Add(new Engine() { EngineSize = 6.7, FuelType = "Disel", HorsePower = 440, NumCylinders = 8 });

            // build cars
            carDict.Add("1000FB", new Car() { CarType = "Sedan", Color = "Green", Year = 2014, Make = "Ford", Model = "Focus", GasTankCapacity = 14, Engine = engines[0] });
            carDict.Add("2020CV", new Car() { CarType = "Sedan", Color = "Red", Year = 2012, Make = "Ford", Model = "Fusion", GasTankCapacity = 18, Engine = engines[1] });
            carDict.Add("2050FD", new Car() { CarType = "Truck", Color = "Black", Year = 2017, Make = "Ford", Model = "F-250", GasTankCapacity = 34, Engine = engines[2] });


            while (true)
            {
                Console.Write(menu);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        //Build a car
                        Console.Write("Enter the stock number: ");
                        string stockNum = Console.ReadLine();

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


                        //cars.Add(myCar);

                        // add the car object to the dictionary using the stock number as a key.
                        carDict.Add(stockNum, myCar);
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
                        Console.Write("Enter the stock number to remove a car: ");
                        string sn = Console.ReadLine();

                        // how to remove a car from the dictionary

                        // the Remove method returns a boolean value.
                        // true if the car object exists and has been successfully removed from the dictionary.
                        // otherwise, false.
                        if (carDict.Remove(sn))
                            Console.WriteLine($"Car with stock number {sn} removed");
                        else
                            Console.WriteLine($"Car with stock number {sn} does not exist");


                        break;
                    case 4:
                        Console.Write("Enter the stock number to search for a car: ");
                        string stockNumber = Console.ReadLine();

                        if (carDict.ContainsKey(stockNumber))
                            Console.WriteLine(carDict[stockNumber]);
                        else
                            Console.WriteLine($"The stock number {stockNumber} does not exist");
                        break;
                    case 5:
                        Console.Write("Specify the car that has been sold: ");
                        string transferKey = Console.ReadLine();

                        if (carDict.Remove(transferKey, out Car car))
                            soldDict.Add(transferKey, car);
                        else
                            Console.WriteLine($"Cannot perform operation: The stock number {transferKey} does not exist in the list.");
                        break;
                    case 6:
                        Console.Write("Enter the stock number to search for a car: ");
                        string soldStockNumber = Console.ReadLine();

                        if (soldDict.ContainsKey(soldStockNumber))
                            Console.WriteLine(soldDict[soldStockNumber]);
                        else
                            Console.WriteLine($"The stock number {soldStockNumber} does not exist");
                        break;
                    case 7:
                        // if you want to loop through the dictionary, then you must use KeyValuePair

                        foreach (KeyValuePair<string, Car> kvp in carDict)
                        {
                            // get the key that is associated with the value
                            Console.WriteLine($"Car Stock # {kvp.Key}");
                            Console.WriteLine(kvp.Value);
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        DisplayEngines();
                        break;
                    case 9:
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
