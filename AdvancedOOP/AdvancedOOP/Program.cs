using System;

namespace AdvancedOOP
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

                        // create a new car object
                        myCar = new Car(make, model, year, color, carType, gtc);

                        Array.Resize(ref cars, cars.Length + 1);
                        cars[cars.Length - 1] = myCar;
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.Write($"Enter the number to remove a car (1 - {cars.Length}): ");

                        int choice = int.Parse(Console.ReadLine());

                        // Shift all car objects over by one based on choice
                        for (int index = choice; index < cars.Length; index++)
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
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
