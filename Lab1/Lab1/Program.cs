using System;
using PG2Input;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Input.ReadInteger("Year: ", 1908, 2021);
            int passengers = Input.ReadInteger("Number of passengers: ", 1, 10);

            string make = string.Empty;
            Input.ReadString("Make: ", ref make);
            string model = string.Empty;
            Input.ReadString("Model: ", ref model);
        }
    }
}