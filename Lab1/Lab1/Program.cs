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
        }
    }
}