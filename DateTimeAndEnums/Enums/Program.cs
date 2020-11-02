using System;

namespace Enums
{
    class Program
    {
        enum Levels
        {
            Easy,
            Medium,
            Hard
        }

        enum Months
        {
            Januay =1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Levels.Easy);
            Console.WriteLine((int)Levels.Easy);

            Console.Write("1. Easy\n2. Medium\n3. Hard\n\nEnter a level to play: ");
            int level = int.Parse(Console.ReadLine()) - 1;

            switch(level)
            {
                case (int)Levels.Easy:
                    Console.WriteLine("You picked an easy level");
                    break;
                case (int)Levels.Medium:
                    Console.WriteLine("You picked a medium level");
                    break;
                case (int)Levels.Hard:
                    Console.WriteLine("You picked a hard level");
                    break;
            }

            switch (Levels.Medium)
            {
                case Levels.Easy:
                    Console.WriteLine("You picked an easy level");
                    break;
                case Levels.Medium:
                    Console.WriteLine("You picked a medium level");
                    break;
                case Levels.Hard:
                    Console.WriteLine("You picked a hard level");
                    break;
            }

            Console.WriteLine((int)Months.February);
            Console.WriteLine((int)Months.May);
            // Console.WriteLine(Months.May);


            Console.WriteLine(Enum.GetName(typeof(Months), 2));

            // get all the values of the Months enum
            //foreach (int i in Enum.GetValues(typeof(Months)))
            //{
            //    Console.Write($" {i}: ");
            //    Console.WriteLine(Enum.GetName(typeof(Months), i));
            //}

            //foreach (string name in Enum.GetNames(typeof(Months)))
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
