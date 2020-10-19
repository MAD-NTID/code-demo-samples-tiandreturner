using System;

namespace DateTimes
{
    class Program
    {

        // More information about DateTime: 
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        static void Main(string[] args)
        {
            // DateTime
            DateTime datetime = DateTime.Now;

            Console.WriteLine("Using datetime");
            Console.WriteLine(datetime.DayOfWeek);
            Console.WriteLine(datetime.ToLongDateString());
            Console.WriteLine(datetime.ToLongTimeString());
            Console.WriteLine(datetime);
            Console.WriteLine(datetime.ToLongDateString() + " " + datetime.ToLongTimeString());
            Console.WriteLine(datetime.ToShortDateString());
            Console.WriteLine(datetime.ToShortTimeString());
            Console.WriteLine(datetime.ToString("M-d-y"));

            if(datetime.DayOfWeek.ToString() == "Monday")
            {
                Console.WriteLine("Today is monday!");
            }


            Console.WriteLine("Using secDateTime");
            DateTime secDateTime = new DateTime();
            Console.WriteLine(secDateTime.ToLongTimeString());
        }
    }
}
