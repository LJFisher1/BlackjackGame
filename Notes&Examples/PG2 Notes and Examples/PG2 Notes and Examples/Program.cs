using System;

namespace PG2_Notes_and_Examples
{
    class Program
    {
        // put cursor over any methods to see what they do if confused
        static void Main(string[] args)
        {
            // if you want to call the method, call the method it by name

            // this is how you call a method that doesn't return anything
            // with no parameters
            PrintRandomNumbers();
            // When you call a method that returns something to you
            // most of the time you need to store that in a variable
            // you also have to assign a value from the method call

            //this is how you call a method that takes two parameters and returns a double
            double returnedDouble = Multiplier(10, 3);
            // $ - C# interpolated strings
            Console.WriteLine($"10 * 3 = {returnedDouble}"); // returns 33 because number++ modified 10 to 11
            // part of the notes.cs
            double num = 5;
            double num2 = 10;
            double product = Multiplier(num, num2); // passing by value
            Console.WriteLine($"{num} * {num2} = {product}");
            // Because we modified number in multiplier it will say 5 * 10 = 60.
            // It modifies just that copy but not the original variable
            
            // this is for the pass by reference example
            double number = 5;
            Console.Write(number);
            double multiplier = RandomFactor(ref number);
            Console.WriteLine($" * {multiplier} = {number}");

            // Out parameter example

            string outmessage = "Because I'm Fatman";
            bool isInString = WhereIsFatman(outmessage, out int indexOfFatman);
            Console.WriteLine($"Fatman is in the string? {isInString}. Index: {indexOfFatman}");

            // Optional parameter
            // in PostFix, number will be set to 99
            string postfixed = PostFix("Hello Spider-World", 99);
            Console.WriteLine(postfixed);

            // in PostFix, number will be 1
            postfixed = PostFix("Hello Spider-World");
            Console.WriteLine(postfixed);




            // --------------------------------------------------------------

            //\/\/\/\ CHALLENGES /\/\/\/\//
            PrintMessage();

            // stores the returned message to a new variable so that it can be used later
            string message = GetMessage();
            PrintMessage(message);

            // TimeStamp challenge
            TimeStamp(ref message);
            Console.WriteLine(message);

            // Out parameter challenge

            MyFavoriteNumber(out int myFav);
            Console.WriteLine($"My favorite number is {myFav}.");




            // --------------------------------------------------------------
        }

        //a method that does not return anything
        private static void PrintRandomNumbers()
        {
            // create an instance of the random class that you can call the methods on
            Random random = new Random();
            // assign a random value to an integer
            int randomNumber = random.Next();
            // assign a random value to a double
            double randomDouble = random.NextDouble();
            // print out the random numbers
            Console.WriteLine(randomNumber);
            Console.WriteLine(randomDouble);
            // don't need a return statement since the method is void
        }

        // a method that returns a double multiplied by a factor
        // it will create 2 new variables: number and factor
        // and copies the values from num and num2
        // into these new variables
        private static double Multiplier(double number, double factor)
        {
            number++; // This modifies only this copy of the variable
            double result = number * factor;
            return result;
        }

        //private static void PrintMessage()
        //{
        //    // this prints the message below
        //    Console.WriteLine("This is the print message method");
        //}

        // overloaded PrintMessage
        // changed to optional parameter, does the same thing as both print messages combined
        private static void PrintMessage(string messageToPrint = "This is the print message method")
        {
            Console.WriteLine(messageToPrint);
        }

        private static string GetMessage()
        {
            // prompts the user for a message 
            Console.Write("What message would you like to return? ");
            // stores that message in a string variable
            string msg = Console.ReadLine();
            // returns that variable to main
            return msg;
        }
        private static double RandomFactor(ref double num) // num is an alias of number for number
        {
            Random random = new Random();
            double factor = random.Next(100);
            num *= factor;
            return factor;
        }
        // Takes the reference of message and adds a TimeStamp to it set to the current
        // date/time of the system
        private static void TimeStamp(ref string message)
        {
            message = $"{DateTime.Now} {message}";
        }
        
        // Out parameter examples

        private static bool WhereIsFatman(string outmessage, out int index)
        {
            // in this method you are required to add a value to index (whatever your out is)
            // before it returns
            index = outmessage.IndexOf("Fatman");
            return index != -1;// != -1 returns true, -1 returns false
        }
        private static void MyFavoriteNumber(out int favorite)
        {
            Console.Write("What is your favorite number? ");
            string favnum = Console.ReadLine();
            bool isANumber = int.TryParse(favnum, out favorite);
            if(isANumber == false)
            {
                Console.WriteLine("Invalid number.");
            }
        }
        private static string PostFix(string msg, int number = 1)
        {
            return $"{msg} #{number}";
        }
    }
}
