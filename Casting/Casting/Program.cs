using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FREEZING_POINT = 32;
            const double FIVE_OVER_NINE = 5.0 / 9;
            const double BOILING_POINT = 273.15;
            double celsius; // variable declarion 

            Console.WriteLine("Enter degree in F: ");
            // Variable initialization
            double fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - FREEZING_POINT) * FIVE_OVER_NINE;
            double kelvin = celsius + BOILING_POINT;

            Console.WriteLine("Celsius: " + celsius
                + "\nKelvin: " + kelvin);

            Console.WriteLine("Celsius: {0}\nKelvin: {1}", 
                celsius, kelvin);

            Console.WriteLine($"Celsius: {(int)celsius}\nKelvin: {(int)kelvin}");

            int numberOfItemsSold = 50;
            Console.WriteLine("You have sold " + (numberOfItemsSold + 8) + " items");

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.ReadLine();

        }
    }
}
