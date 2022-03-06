using System;
using PG2Input;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
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
            static void Main(string[] args)
            {
                string speech = GetSpeech();

                string[] listOfWords = speech.Split(new char[] { ' ', ',', '.', ':', '?', '-', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                List<string> words = new List<string>(listOfWords);
                List<string> sentences = new List<string>(speech.Split(new char[] { '.', '?', '!' }));

            Dictionary<string, int> wordDictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < words.Count; i++)
            {
                if(wordDictionary.ContainsKey(words[i]))
                {
                    //dictionary, finding the value for the key (words[i]), words[i] is a string (adding a count of the word if it is there)
                    wordDictionary[words[i]]++;
                }
                else
                {   //dictionary, adding an instance of words at [i] (adding a word if its not there)
                    wordDictionary.Add(words[i], 1);
                }
            }
            static void NewMethod(int length)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                for (int i = 0; i < length; i++)
                {

                    Console.Write(new string(" "));
                }
                Console.ResetColor();
                
            }
            
            static void RemoveWord(string theKey, Dictionary<string, int> wordDictionary)
            {
                theKey = Console.ReadLine();
                
                bool isRemoved = wordDictionary.Remove(theKey);
                if(isRemoved)
                {
                    Console.WriteLine($"'{theKey}' was removed.");
                }
                else
                {
                    Console.WriteLine($"'{theKey}' was not found.");
                }
            }

                // A-5 Menu Loop
                bool menuRun = true;
                string choice = "Pick a choice: ";
                string[] options = { "1. Speech", "2. List of Words", "3. Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
                int selection;
            while (menuRun)
            {  
                Input.ReadChoice(choice, options, out selection);
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Console.Write(speech);
                        Console.WriteLine("\n\nPress any key to return to menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < words.Count; i++)
                        {
                            Console.WriteLine(words[i]);
                        }
                        Console.Write("Press any key to return to menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                            foreach (KeyValuePair<string, int> item in wordDictionary)
                            {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(item.Key);
                            Console.CursorLeft = 15;
                            Console.ResetColor();
                            NewMethod(item.Value);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(item.Value);
                            Console.ResetColor();
                        }
                        
                        Console.ResetColor();
                        Console.Write("Press any key to return to menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        string searchWord = "";
                        Console.Clear();
                        Input.ReadString("What word would you like to search for? ", ref searchWord);
                        if(wordDictionary.ContainsKey(searchWord))
                        {
                            Console.Write($"{searchWord}");
                            NewMethod(wordDictionary[searchWord]);
                            Console.Write(wordDictionary[searchWord] + "\n");
                            foreach (string singleSentence in sentences)
                            {
                                List<string> sent = new List<string>(singleSentence.Split(new char[] { ' ', ',', '.', ':', '?' }, StringSplitOptions.RemoveEmptyEntries));
                                foreach (string word in sent)
                                {
                                    if(searchWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine(singleSentence);
                                    }
                                }
                            }
                            Console.Write("Press any key to return to menu..");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($" '{searchWord}' was not found..");
                            Console.Write("Press any key to return to menu..");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("What word would you like to remove? ");
                        string removedWord = "";
                        RemoveWord(removedWord, wordDictionary);
                        Console.Write("Press any key to return to the menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Write("Exit");
                        menuRun = false;
                        break;
                }
            }
            }
        
    }
}