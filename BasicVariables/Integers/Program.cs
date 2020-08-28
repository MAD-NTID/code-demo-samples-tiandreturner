using System;

namespace Integers
{
    /* This is a multiline comment
     * 
     * Author: Tiandre Turner
     * Date: 08/24/2020
     * Description: Demostrating the concepts of basic variables
     * Caveats: None
     */
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 11;
            //int y = x + 5;
            //Console.WriteLine(y);


            // this is a single comment
            int myAge = 25;
            int dogAge = myAge * 7;
            // Displaying my age and the dog's age  in two different approaches
            Console.WriteLine("Age: " + myAge + " Dog Age: " + dogAge);
            Console.WriteLine("Age: {0} Dog Age: {1}", myAge, dogAge);
        }
    }
}