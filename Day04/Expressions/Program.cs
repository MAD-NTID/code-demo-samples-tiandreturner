using System;

namespace Expressions
{
    /*
     * Name: Professor Turner
     * Date: 08/26/2020
     * Course: NMAD.180 - Programming Fundamentals I
     * Purpose: Teach students about expressions
     * Caveats: None
     */
    class Program
    {
        static void Main(string[] args)
        {
            // this is a statement
            int costPerCredit = 850; // variable initialization
            int credits = 15;
            credits = 20;

            // this is an expression
            int subtotal = costPerCredit * credits;
            int scholarship = 7000;
            Console.WriteLine("Subtotal: {0:C}", subtotal);
            Console.WriteLine("Scholarship: {0:C}", scholarship);
            Console.WriteLine("Net Total: {0:C}", subtotal - scholarship);

            //Console.WriteLine("Total: {0:C}", costPerCredit * credits);
        }
    }
}
