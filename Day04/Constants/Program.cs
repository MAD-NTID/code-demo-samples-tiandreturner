using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DAYS_OF_THE_WEEK = 7;
            int numOfWeeks = 52;
            //Console.WriteLine("Number of days: {0}",
            //    DAYS_OF_THE_WEEK * 52); //  no magic number!

            Console.WriteLine("Number of days: {0}",
                DAYS_OF_THE_WEEK * numOfWeeks);
        }
    }
}
