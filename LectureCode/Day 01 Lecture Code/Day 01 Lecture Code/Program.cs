using System;

namespace Day_01_Lecture_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            Console.ReadKey();
        }

        static void PrintMessage()
        {
            Console.WriteLine("German superheroes are the wurst!");
        }

        static string GetMessage()
        {
            Console.Write("Please enter your favorite superhero? ");
            string Message = Console.ReadLine();
            return Message;
        }
    }
}
