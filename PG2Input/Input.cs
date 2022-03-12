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
            int zed = 0;
            while(validInput == false)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out int validOutput))
                {
                    if (validOutput >= min && validOutput <= max)
                    {
                        zed = validOutput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input out of range, try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Thats not an option.");
                }
            }
            return zed;

        }

     
       
        public static void ReadString(string prompt, ref string value)
        {
            bool validString = false;          
            while (validString == false)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                {                  
                    if (string.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("Invalid entry.");
                    }
                    else
                    {
                        value = s;
                        break;
                    }
                }   
            }
        }
        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            foreach (string s in options)
            {
                Console.WriteLine($"{s}");
            }
            selection = ReadInteger(prompt, 1, options.Length);
        }
        }  
}
