using System;

namespace PlayingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "animal";
            //string toFind = "n";

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Enter the character you wish to find: ");
            string toFind = Console.ReadLine();

            Console.WriteLine(SearchChar(str, toFind));
            
        }// end method main

        private static string SearchChar(string str, string toFind)
        {
            int index = str.IndexOf(toFind);

            if (index == -1)
            {
                return String.Format($"Cannot find {toFind} in {str}");
            }
            else
            {
                return String.Format($"Found '{toFind}' in '{str} at position {index}");
            }
        }
    }// end class Program
}
