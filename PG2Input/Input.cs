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
                    if (validOutput > min && validOutput < max)
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
                    Console.WriteLine("Thats not an integer.");
                }
            }
            return zed;

        }

        //Create a method called ReadString that will ask the user for a string. Instead of returning the value like in 
        // ReadInteger, you should use pass by reference to get the string back to the caller.The method should show a
        //prompt, read the user’s input, store the input in the ref parameter.If the user does NOT enter a string, show an
        //error message to them, show the prompt again and ask for the user’s input. You’ll need a loop for this. Do not
        // return until the user enters something. You should use the IsNullOrEmpty or the IsNullOrWhiteSpace methods of 
        // the string class to check if the string is empty


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
        //        Create a method called ReadChoice that will ask the user to select from a list of options, like a menu.Instead of
        //returning like ReadInteger or passing back the value like ReadString, you should return the selection through an 
        //out parameter.The method should show a list of options to the user, show a prompt, get the user’s selection, and 
        //return the selection through an out parameter.
        //You’ll need to pass the list of options as a string array.Something like string[] {“1.Add Car”, “2.Show Cars”, “3.
        //Exit” }. The method should loop over the array and show each option on a new line.Then it should show the
        //prompt and read the user’s input.You should use your ReadInteger method you created earlier
        static void ReadChoice(string prompt, string[] options, out int selection)
        {
            for(int i = 0; i < options.Length; i++)
            {

            }
                selection = something using readint method

        }
    }  
}
