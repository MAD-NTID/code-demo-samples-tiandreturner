using System;

namespace MoreLoopsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numArray = new int[10]; // creates an array of 10 elements that stores integers
            //numArray[0] = (int)15.6; // casting 15.6 to become 15

            Console.Write("How many students are in your class?: ");
            int classSize = int.Parse(Console.ReadLine());

            string[] classList = new string[classSize];
            for(int i = 0; i < classList.Length; i++)
            {
                Console.Write($"Enter student {i + 1}: ");
                classList[i] = Console.ReadLine();
            }

            Console.WriteLine($"Currently there are {classList.Length} students in the class");
            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine(classList[i]);
            }
            //Console.Write("How many new students do you want to add to the classroom: ");
            //int additionalStudents = int.Parse(Console.ReadLine());

            //Array.Resize(ref classList, classList.Length + additionalStudents);

            //Console.WriteLine($"Currently there are {classList.Length} students in the class");
            //for (int i = 0; i < classList.Length; i++)
            //{
            //    Console.WriteLine(classList[i]);
            //}
        }
    }
}
