using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        public static int ReadInteger(string entry, int )
        {
            Console.Write("Please enter an integer: ");
            string userInput = Console.ReadLine();
            bool validEntry = int.TryParse(userInput, out int validInput);
            if (validEntry)
            {
                Console.WriteLine("Good on you for entering a valid integer.");
            }
            else
            {
                Console.Write("Sorry, thats an invalid entry. Please try again: ");
            }
            return validInput;
        }
    }   
}
