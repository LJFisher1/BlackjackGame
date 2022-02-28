using System;

namespace Day_01_Lecture_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);

            int num1 = 10, num2 = 50;
            int result = Add(num1, num2);
            Console.ReadKey();
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void PrintMessage(string one)
        {
            Console.WriteLine(one);
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
