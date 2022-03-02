using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        static int ReadInteger()
        {
            Console.Write("Please enter an integer: ");
            string userInput = Console.ReadLine();
            bool validInput = int.TryParse(userInput, out int validOutput);
            if(validInput)
            {

            }
            else
            {

            }
            return 0;
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
