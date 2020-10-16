using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = String.Format("1. Build a car\n2. Remove a car\n" +
                "3. List all cars\n4. Exit\n\nEnter your option: ");

            Car myCar;
            Car[] cars = new Car[0];

            while (true)
            {
                Console.Write(menu);

                switch(int.Parse(Console.ReadLine()))
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

                        // create a new car object
                        myCar = new Car(make, model, year, color, carType);

                        Array.Resize(ref cars, cars.Length + 1);
                        cars[cars.Length - 1] = myCar;
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.Write($"Enter the number to remove a car (1 - {cars.Length}): ");

                        int choice = int.Parse(Console.ReadLine());

                        // Shift all car objects over by one based on choice
                        for(int index = choice; index < cars.Length; index++)
                        {
                            // same as cars[choice -1] = cars[choice];
                            cars[index - 1] = cars[index];
                        }

                        //cars[choice] = null;

                        Array.Resize(ref cars, cars.Length - 1);
                        break;
                    case 3:
                        for (int i = 0; i < cars.Length; i++)
                        {
                            if(cars[i] == null)
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
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }

            //// to create an object.
            //Car myCar = new Car();
            //myCar.Price = 5000;
            ////myCar.Make = "Chevrolet";
            ////myCar.Model = "Express";
            ////myCar.Year = 2006;
            ////myCar.HasGPS = false;
            ////myCar.HasRadio = true;
            ////myCar.TypeOfTires = "Seasonal Tires";
            ////myCar.Price = 2000;
            ////myCar.Windows = "Tinted Windows";
            ////myCar.Color = "Tan";
            ////myCar.IsRunning = true;

            //Console.WriteLine("Data for the first car object");
            //Console.WriteLine(myCar);

            //myCar.Price = -2300;
            //Console.WriteLine("\n\nData for the first car object after change to -2300");
            //Console.WriteLine(myCar);

            ////Console.WriteLine("Make: " + myCar.Make);
            ////Console.WriteLine("Model: " + myCar.Model);
            ////Console.WriteLine($"Color: {myCar.Color}");
            ////Console.WriteLine($"Price: {myCar.Price}");
            ////Console.WriteLine("Year: {0}", myCar.Year);
            ////Console.WriteLine("Type of tires: {0}", myCar.TypeOfTires);
            ////myCar.Drive();

            //Car jamesCar = new Car("White", "Regular Windows", "Seasonal Tires", 
            //    false, "Sedan Doors", "Small Rod", 7000, true, 2013, "Car", "Ford", "Focus", false);
            ////jamesCar.Make = "Ford";
            ////jamesCar.Model = "Focus";
            ////jamesCar.Year = 2013;
            ////jamesCar.HasRadio = true;
            ////jamesCar.HasGPS = false;
            ////jamesCar.Color = "White";
            ////jamesCar.Drive();

            //Console.WriteLine("\n\nData for james's car object");
            //Console.WriteLine(jamesCar.ToString());
            //jamesCar.Drive();
            ////Console.WriteLine("Make: " + jamesCar.Make);
            ////Console.WriteLine("Model: " + jamesCar.Model);
            ////Console.WriteLine($"Color: {jamesCar.Color}");
            ////Console.WriteLine($"Price: {jamesCar.Price}");
            ////Console.WriteLine("Year: {0}", jamesCar.Year);
            ////Console.WriteLine("Type of tires: {0}", jamesCar.TypeOfTires);

            ////int[] array = { 50, 60 };

            //Car propCar = new Car();
            //propCar.Year = 2000;
            //propCar.Color = "Yellow";
            //propCar.Make = "Ford";
            //propCar.Model = "F150";
            //propCar.Price = 400;

            //Console.WriteLine("\n\n" + propCar);

            //Car oisCar = new Car()
            //{
            //    Year = 1899,
            //    Color = "Blue",
            //    Make = "Chevrolet",
            //    Model = "Avalanche",
            //    Price = 5000
            //};

            //Console.WriteLine($"\n\n{oisCar}");
        }
    }
}
