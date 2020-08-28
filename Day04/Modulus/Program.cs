using System;

namespace Modulus
{
    /*
     * Name: Professor Turner
     * Date: 08/26/2020
     * Course: NMAD.180 - Programming Fundamentals I
     * Purpose: Teach students about modulus, the concept of remainders
     * Caveats: None
     */
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 5 % 3;
            Console.WriteLine(remainder);

            int remainder2 = 100 % 25;
            Console.WriteLine(remainder2);

            // PEMDAS
            int total = (23 + 5) / 2 * 5;
            Console.WriteLine(total);

            int total2 = 15 / 2;
            Console.WriteLine(total2);

            // new data type -- double
            double total3 = 15 / 2.0;
            Console.WriteLine(total3);
        }
    }
}
