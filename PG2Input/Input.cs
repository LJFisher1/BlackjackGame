using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        public static int ReadInteger(string userInput, int min, int max)
        {
            min = int.MinValue;
            max = int.MaxValue;
            int goodValue = 0;
            // prompt user for input
            Console.WriteLine("Please enter an integer: ");
            // read the input
            userInput = Console.ReadLine();
            // convert input from string to int
            bool validInput;
            // check to see if the input is valid
            int.TryParse(userInput, out int validOutput);
            // if input is valid continue, otherwise loop back
            if (validOutput > min && validOutput < max)
            {
                validInput = true;
                if (validInput == true)
                {
                    goodValue = validOutput;
                }
            }
            else
            {
                Console.Write("Thats not a valid integer...");
            }
            // return int
            return goodValue;
            
        }
        static void ReadString()
        {
            Console.Write("");
        }
        static void ReadChoice()
        {

        }
    }  
}
