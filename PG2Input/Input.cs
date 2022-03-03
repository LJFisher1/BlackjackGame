using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            bool validInput = false;
            int one = 0;
            while(validInput == false)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out int validOutput))
                {
                    if (validOutput > min && validOutput < max)
                    {
                        one = validOutput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input out of range, user loser");
                    }
                }
                else
                {
                    Console.WriteLine("Try again..");
                }
            }
            return one;

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
