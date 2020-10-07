using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // to create an object.
            Car myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Express";
            myCar.Year = 2006;
            myCar.HasGPS = false;
            myCar.HasRadio = true;
            myCar.TypeOfTires = "Seasonal Tires";
            myCar.Price = 2000;
            myCar.Windows = "Tinted Windows";
            myCar.Color = "Tan";
            myCar.IsRunning = true;
           


            Console.WriteLine("Data for the first car object");
            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine($"Color: {myCar.Color}");
            Console.WriteLine($"Price: {myCar.Price}");
            Console.WriteLine("Year: {0}", myCar.Year);
            Console.WriteLine("Type of tires: {0}", myCar.TypeOfTires);
            myCar.Drive();

            Car jamesCar = new Car();
            jamesCar.Make = "Ford";
            jamesCar.Model = "Focus";
            jamesCar.Year = 2013;
            jamesCar.HasRadio = true;
            jamesCar.HasGPS = false;
            jamesCar.Color = "White";
            //jamesCar.Drive();

            Console.WriteLine("Data for james's car object");
            jamesCar.Drive();
            Console.WriteLine("Make: " + jamesCar.Make);
            Console.WriteLine("Model: " + jamesCar.Model);
            Console.WriteLine($"Color: {jamesCar.Color}");
            Console.WriteLine($"Price: {jamesCar.Price}");
            Console.WriteLine("Year: {0}", jamesCar.Year);
            Console.WriteLine("Type of tires: {0}", jamesCar.TypeOfTires);
        }
    }
}
