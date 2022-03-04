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

            int menuChoice = 0;
            string[] mainMenu = new string[] { "1. Add Car", "2. Show Cars", "3. Exit" };
            Input.ReadChoice("Choice? ", mainMenu, out menuChoice);


            // A-5 Menu Loop

            // You will need to create a loop in Main that handles the menu options for lab 1.
            //• This should be a simple while loop that loops while the menu selection is NOT exit.
            //• Inside the while loop, you should…
            //o Call ReadChoice to show the menu and get the user’s menu selection
            //o use a switch statement that has logic for each menu option.
            // 1: The Speech
            // 2: List of Words
            // 3: Show Histogram
            // 4: Search for Word
            // 5: Remove Word
            // 6: Exit
            //NOTE: for Part A, you will only need code to handle the exit option
            // You should have a menu loop that shows the menu and let’s the user select a menu option.


            // B-1 The Speech

            //NOTE: find the data to use for this project in the speechString.txt file for the lab.
            //Create a method called GetSpeech.It should return the string from the speechString.txt file. Copy the text
            //from the file to the method.


            // B-2 List of Words

            // Split the string into an array of words that appear in the string. You need to figure out what the possible 
            // delimiter(s) are to give you all the words(look at all the characters in the string that separate the words).
            //Now convert array of words to a list of strings. This should happen BEFORE the menu loop.
            //Add code to the second menu option to show the list of words.First, clear the screen then print each word of
            //the list on a separate line. Wait for user to press a key before clearing the screen and showing the menu again.


            // C-1 Word Counts

            // Now that you have the list of words, you need to calculate how many times each word appears in the list of words. 
            //Create a Dictionary to store those counts.The key of the dictionary will be the words and the value will be the
            //counts.Loop over the List of words and put or update the word in the dictionary.
            //Do this BEFORE the menu loop.
            //NOTES:
            //• Make it case-insensitive meaning that if the word is upper -case and lower-case in the data, only 1 will
            // appear in the dictionary. For example, ‘The’ and ‘the’ are the same word so only one should be in the
            //dictionary.HINT: look at the different constructors for Dictionary to make this easier.
            //• You need to check if the word is in the dictionary to decide if it should be added or if it should be
            //updated.Use ContainsKey or TryGetValue


            // C-2 Show Histogram

            //Now you have the information you need to add logic to the menu for the “Show Histogram” option.For each word 
            //in the dictionary, print the word, the count and a bar representing the count as a horizontal bar chart(see
            //screenshot).Format your chart to make it look nice! Use Console.CursorLeft to align the bars


            // C-3 Search for Words

            //Now you have the information you need to add logic to the menu for the “Search for Word” option. Ask the user 
            //for a word to search for (“What word do you want to find ? “). Use ReadString to get the word from the user!
            //If the word is in the Dictionary, print the word, bar, and count.


            // C-4 (BOOM), Sentences for Word

            //ADD TO PART C-3
            //Show the sentences that the word appears in. HINT: you can split the original speech text on different delimiters
            //to get the sentences.
            //If the word is NOT in the dictionary, print “< word > is not found.”. (replace < word > with what the user entered


            // C-5 Remove Word

            //ADD TO PART C-3
            //Show the sentences that the word appears in. HINT: you can split the original speech text on different delimiters
            //to get the sentences.
            //If the word is NOT in the dictionary, print “< word > is not found.”. (replace < word > with what the user entered

        }
    }
}