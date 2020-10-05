using System;
using System.Security.Cryptography.X509Certificates;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Good morning! ";
            //string s2 = "Good afternoon!";
            //string s3 = String.Concat(s1, s2);

            //Console.WriteLine(s3);

            //char c = s1[6];
            //Console.WriteLine(c);
            double total = 0;

            Console.Write("Enter the subtotal: ");
            double subtotal = double.Parse(Console.ReadLine());

            Console.Write("Does your state collect tax? (y/n): ");
            char c = Console.ReadLine().ToUpper()[0];

            if(c == 'Y')
            {
                Console.Write("Enter the sales tax (%): ");
                double salesTax = double.Parse(Console.ReadLine());
                total = CalculateTotal(subtotal, salesTax / 100);
            }
            else
            {
                total =CalculateTotal(subtotal);
            }

            Console.WriteLine($"{total:C}");
        }

        /// <summary>
        /// Calculates the sales tax based on the sales tax amount in percentage format
        /// </summary>
        /// <param name="subtotal">The subtotal of an order</param>
        /// <param name="salesTax">The sales tax percentage in double format if none given, then default value is 0</param>
        /// <returns></returns>
        public static double CalculateTotal(double subtotal, double salesTax = 0)
        {
            return subtotal + (subtotal * salesTax);
        }
    }
}
