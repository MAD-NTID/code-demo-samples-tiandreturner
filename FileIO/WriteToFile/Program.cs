using System;
using System.IO;

namespace WriteToFile
{
    // StreamWriter -- https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("bad.txt"))
            {
                StreamReader sr = new StreamReader("bad.txt");
                //Console.WriteLine(sr.ReadLine());
                //Console.WriteLine(sr.ReadLine());
                //Console.WriteLine(sr.ReadLine());

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            // Last week friday, we talked about how to read from
            // a file. Today, we will be talking about how to WRITE to a file.

            // Use a StreamWRiter Object
            //using (StreamWriter sw = new StreamWriter("writings.txt"))
            //{
            //    // you can use the WriteLine method many times, but it does not
            //    // mean that it will literally write to the file right away.
            //    sw.WriteLine("Hello, I am writing to this file.");
            //    sw.WriteLine("This is a second line");
            //    // You must use the Flush method, so you may flush EVERYTHING
            //    // to a file.
            //    sw.Flush();
            //}

            //using (StreamWriter sw = new StreamWriter("students.csv"))
            //{
            //    // you can use the WriteLine method many times, but it does not
            //    // mean that it will literally write to the file right away.
            //    sw.WriteLine("James,Hughes,2nd Year,Developing AI");
            //    // which year are you in?>
            //    sw.WriteLine("William,Arnold,3rd Year,Playing Video Games");
            //    // You must use the Flush method, so you may flush EVERYTHING
            //    // to a file.
            //    sw.Flush();
            //}

            using (StreamReader sr = new StreamReader("students.csv"))
            {
                string line = "";
                char[] delimiters = { ',', 'e' };
                while((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(",");

                    Console.WriteLine($"Name: {info[0]} {info[1]}");
                    Console.WriteLine($"Year: {info[2]}");
                    Console.WriteLine($"Hobby: {info[3]}\n");
                }
            }
        }
    }
}
