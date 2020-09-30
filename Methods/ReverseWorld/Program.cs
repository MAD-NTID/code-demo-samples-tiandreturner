using System;

namespace ReverseWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            PrintTheFirstLetterOfFirstName(firstName);

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            PrintTheFirstLetterOfLastName(lastName);
        }

        // Not recommended

        public static void PrintTheFirstLetterOfFirstName(string firstName)
        {
            char letter = firstName[0];
            Console.WriteLine("The first letter of your first name is: " + letter);
        }

        public static void PrintTheFirstLetterOfLastName(string lastName)
        {
            //char letter = lastName[0];
            //Console.WriteLine("The first letter of your first name is: " + letter);
            //char letter = lastName[0];

            char character = 'B'; // only hold ONE character
            string name = "BA"; // can hold more than one character
            char letter;

            for (int index = 0; index < lastName.Length; index++)
            {
                // if the character is in uppercase
                if (Char.IsUpper(lastName[index]))
                {
                    letter = lastName[index];
                    Console.WriteLine("The first letter of your last name is: " + letter);
                }
            }

        }
    }
}
