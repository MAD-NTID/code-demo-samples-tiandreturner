using System;
using System.IO;

namespace FileIO
{
  
    class Program
    {
        // System.IO -- https://docs.microsoft.com/en-us/dotnet/api/system.io?view=net-5.0
        static void Main(string[] args)
        {
            // Today, we will be learning about FILE IO.

            // I will show you how to read the file
            // First you will need to know the path to a specific file.

            // ALSO, this is something that you will learn for this week and will
            // be reviewed again next semester in Programming Fundamentals II

            // HOWEVER this is a bad practice!
            //string path = "C:\\Users\\tjtics\\Documents\\pf2.txt";
            //string path = "pf1.txt";
            string path = "pf2.txt";

            //  how do you make this line to become
            // Hello
            // World!
            // keep it in mind that the \ is an espace character
            string newLine = "Hello\nWorld!";

            // OKAY, we will see what happens if we are trying to get this file
            // Next semester, you will be using GUI to select a file and load it in an application.

            // Let's get started with reading a file.
            // Use a StreamReader Object

            // It is very important for you know and understand what are the namespaces
            // Namespaces are like your LIBRARY and classes are your BOOKS
            // Which library we should be using for this to be able to use StreamReader????

            // What do you think using means?
            // It means I will be using the StreamReader object and perform
            // a task to read files. Once it is done, it disappears.
            // this approach is better to manage or save the resources
            // in the memory

            // Remember if the file is not found???
            // Make sure you check if the path to a file does EXIST first

            // what if you create a file OUTSIDE of visual studio??
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    //// WHAT IF you do not know how many lines in the file?
                    //// WHAT should I do??
                    //Console.WriteLine(reader.ReadLine());
                    //Console.WriteLine(reader.ReadLine());
                    //Console.WriteLine(reader.ReadLine());
                    //// any whitespace or new line can be considered as null
                    //Console.WriteLine(reader.ReadLine());
                    //Console.WriteLine(reader.ReadLine());

                    // lets use a loop!
                    // while reading each line (content)
                    // store the information from the line before print them
                    string str = null;
                    while ((str = reader.ReadLine()) != null)
                    {
                        // how can I print something in here????
                        Console.WriteLine(str);
                    }
                }

                // lets see what happens
            }
            else
            {
                Console.WriteLine("File not found");
            }

            // You will be learning about how to write to a file next week Monday.
            // You will be learning about how to read the file and convert to a class
            // next week Wednesday
            // Next week friday, we will be review for the exam
            // the next exam is on the 23rd

            // Last but not at least, you may will get one more homework based on dictionary
            // Also a project but the project will be due after Thanksgiving.
            // I will be discussing with another professor to see how we will do this to make
            // sure the homework and project prepare you for the exam. Also homework to prepare you 
            // for the project
            
            //ANY QUESTION?!
        }
    }
}
