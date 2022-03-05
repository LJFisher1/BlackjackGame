using System;
using PG2Input;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           static string GetSpeech()
            {
              string text = "My third story is about death. When I was 17, I read a quote that went something like: If you live each day as if it was your last, someday you'll most certainly be right. " +
        "It made an impression on me, and since then, for the past 33 years, I have looked in the mirror every morning and asked myself: If today were the last day of my life, " +
        "would I want to do what I am about to do today? And whenever the answer has been No for too many days in a row, I know I need to change something. Remembering that I'll be dead " +
        "soon is the most important tool I've ever encountered to help me make the big choices in life. Because almost everything - all external expectations, all pride, all fear of " +
        "embarrassment or failure - these things just fall away in the face of death, leaving only what is truly important. Remembering that you are going to die is the best way I know" +
        " to avoid the trap of thinking you have something to lose. You are already naked. There is no reason not to follow your heart. About a year ago I was diagnosed with cancer. " +
        "I had a scan at 7:30 in the morning, and it clearly showed a tumor on my pancreas. I didn't even know what a pancreas was. The doctors told me this was almost certainly a type of" +
        " cancer that is incurable, and that I should expect to live no longer than three to six months. My doctor advised me to go home and get my affairs in order, which is doctor's" +
        " code for prepare to die. It means to try to tell your kids everything you thought you'd have the next 10 years to tell them in just a few months. It means to make sure" +
        " everything is buttoned up so that it will be as easy as possible for your family. It means to say your goodbyes. I lived with that diagnosis all day. Later that evening I had" +
        " a biopsy, where they stuck an endoscope down my throat, through my stomach and into my intestines, put a needle into my pancreas and got a few cells from the tumor. I was" +
        " sedated, but my wife, who was there, told me that when they viewed the cells under a microscope the doctors started crying because it turned out to be a very rare form of " +
        "pancreatic cancer that is curable with surgery. I had the surgery and I'm fine now. This was the closest I've been to facing death, and I hope it's the closest I get for a few" +
        " more decades. Having lived through it, I can now say this to you with a bit more certainty than when death was a useful but purely intellectual concept: No one wants to die." +
        " Even people who want to go to heaven don't want to die to get there. And yet death is the destination we all share. No one has ever escaped it. And that is as it should be, " +
        "because Death is very likely the single best invention of Life. It is Life's change agent. It clears out the old to make way for the new. Right now the new is you, but someday" +
        " not too long from now, you will gradually become the old and be cleared away. Sorry to be so dramatic, but it is quite true. Your time is limited, so don't waste it living" +
        " someone else's life. Don't be trapped by dogma - which is living with the results of other people's thinking. Don't let the noise of others' opinions drown out your own inner" +
        " voice. And most important, have the courage to follow your heart and intuition. They somehow already know what you truly want to become. Everything else is secondary. When I" +
        " was young, there was an amazing publication called The Whole Earth Catalog, which was one of the bibles of my generation. It was created by a fellow named Stewart Brand not" +
        " far from here in Menlo Park, and he brought it to life with his poetic touch. This was in the late 1960s, before personal computers and desktop publishing, so it was all made" +
        " with typewriters, scissors and Polaroid cameras. It was sort of like Google in paperback form, 35 years before Google came along: It was idealistic, and overflowing with neat" +
        " tools and great notions. Stewart and his team put out several issues of The Whole Earth Catalog, and then when it had run its course, they put out a final issue. It was the " +
        "mid-1970s, and I was your age. On the back cover of their final issue was a photograph of an early morning country road, the kind you might find yourself hitchhiking on if" +
        " you were so adventurous. Beneath it were the words: Stay Hungry. Stay Foolish. It was their farewell message as they signed off. Stay Hungry. Stay Foolish. And I have always" +
        " wished that for myself. And now, as you graduate to begin anew, I wish that for you. Stay Hungry. Stay Foolish.";
                return text;
            }
            string text = "My third story is about death. When I was 17, I read a quote that went something like: If you live each day as if it was your last, someday you'll most certainly be right. " +
        "It made an impression on me, and since then, for the past 33 years, I have looked in the mirror every morning and asked myself: If today were the last day of my life, " +
        "would I want to do what I am about to do today? And whenever the answer has been No for too many days in a row, I know I need to change something. Remembering that I'll be dead " +
        "soon is the most important tool I've ever encountered to help me make the big choices in life. Because almost everything - all external expectations, all pride, all fear of " +
        "embarrassment or failure - these things just fall away in the face of death, leaving only what is truly important. Remembering that you are going to die is the best way I know" +
        " to avoid the trap of thinking you have something to lose. You are already naked. There is no reason not to follow your heart. About a year ago I was diagnosed with cancer. " +
        "I had a scan at 7:30 in the morning, and it clearly showed a tumor on my pancreas. I didn't even know what a pancreas was. The doctors told me this was almost certainly a type of" +
        " cancer that is incurable, and that I should expect to live no longer than three to six months. My doctor advised me to go home and get my affairs in order, which is doctor's" +
        " code for prepare to die. It means to try to tell your kids everything you thought you'd have the next 10 years to tell them in just a few months. It means to make sure" +
        " everything is buttoned up so that it will be as easy as possible for your family. It means to say your goodbyes. I lived with that diagnosis all day. Later that evening I had" +
        " a biopsy, where they stuck an endoscope down my throat, through my stomach and into my intestines, put a needle into my pancreas and got a few cells from the tumor. I was" +
        " sedated, but my wife, who was there, told me that when they viewed the cells under a microscope the doctors started crying because it turned out to be a very rare form of " +
        "pancreatic cancer that is curable with surgery. I had the surgery and I'm fine now. This was the closest I've been to facing death, and I hope it's the closest I get for a few" +
        " more decades. Having lived through it, I can now say this to you with a bit more certainty than when death was a useful but purely intellectual concept: No one wants to die." +
        " Even people who want to go to heaven don't want to die to get there. And yet death is the destination we all share. No one has ever escaped it. And that is as it should be, " +
        "because Death is very likely the single best invention of Life. It is Life's change agent. It clears out the old to make way for the new. Right now the new is you, but someday" +
        " not too long from now, you will gradually become the old and be cleared away. Sorry to be so dramatic, but it is quite true. Your time is limited, so don't waste it living" +
        " someone else's life. Don't be trapped by dogma - which is living with the results of other people's thinking. Don't let the noise of others' opinions drown out your own inner" +
        " voice. And most important, have the courage to follow your heart and intuition. They somehow already know what you truly want to become. Everything else is secondary. When I" +
        " was young, there was an amazing publication called The Whole Earth Catalog, which was one of the bibles of my generation. It was created by a fellow named Stewart Brand not" +
        " far from here in Menlo Park, and he brought it to life with his poetic touch. This was in the late 1960s, before personal computers and desktop publishing, so it was all made" +
        " with typewriters, scissors and Polaroid cameras. It was sort of like Google in paperback form, 35 years before Google came along: It was idealistic, and overflowing with neat" +
        " tools and great notions. Stewart and his team put out several issues of The Whole Earth Catalog, and then when it had run its course, they put out a final issue. It was the " +
        "mid-1970s, and I was your age. On the back cover of their final issue was a photograph of an early morning country road, the kind you might find yourself hitchhiking on if" +
        " you were so adventurous. Beneath it were the words: Stay Hungry. Stay Foolish. It was their farewell message as they signed off. Stay Hungry. Stay Foolish. And I have always" +
        " wished that for myself. And now, as you graduate to begin anew, I wish that for you. Stay Hungry. Stay Foolish.";
            string[] listOfWords = text.Split(new char[] { ' ', '.', ':', '?', '-', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < listOfWords.Length; i++)
            {
                List<string> words = new List<string>();
                words.Add(listOfWords[i]);
            }

            // A-5 Menu Loop
            bool menuExit = false;
            string[] choices = { "The Speech", "List of Words", "Show Histogram", "Search for Word", "Remove Word", "Exit" };
            while(menuExit)
            {   // stuck on what to do with the read choice/what to put in the switch ()
                Input.ReadChoice();
                switch ()
                {
                    case 1:
                        Console.Clear();
                        GetSpeech();
                        Console.Write("Press any key to return to menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        
                        Console.Write("Press any key to return to menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Show Histogram not yet implemented");
                        break;
                    case 4:
                        Console.Write("Search for Word not yet implemented");
                        break;
                    case 5:
                        Console.Write("Remove Word not yet implemented");
                        break;
                    case 6:
                        Console.Write("Exit");
                        menuExit = true;
                        break;
                }
            }
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