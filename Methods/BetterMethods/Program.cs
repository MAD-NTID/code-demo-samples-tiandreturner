using System;

namespace BetterMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            PrintTheFirstLetter(firstName);

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            PrintTheFirstLetter(lastName);

            ReverseAll(firstName, lastName);
        }

        public static void PrintTheFirstLetter(string name)
        {
            char letter = name[0];
            Console.WriteLine("The first letter of your name is: " + letter);
        }

        public static void ReverseAll(string firstName, string lastName)
        {
            ReverseThis(firstName);
            ReverseThis(lastName);
        }

        public static void ReverseThis(string word)
        {
            string reverse = "";
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);

            for(int index = 0; index < letters.Length; index++)
            {
                reverse += letters[index];
            }

            Console.WriteLine(reverse);
        }
    }
}
