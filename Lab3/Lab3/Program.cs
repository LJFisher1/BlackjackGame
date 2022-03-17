using System;
using PG2Input;
using BlackjackClassLibrary;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand _playerHand = new Hand();
            Hand _dealerHand = new Hand();
            bool menuRun = true;
            string choice = "Pick a choice: ";
            string[] options = { "1. Play Blackjack", "2. Shuffle Hand & Show Deck", "3. Sample Hands", "4. Exit" };
            int selection;
            while (menuRun)
            {
                Input.ReadChoice(choice, options, out selection);
                switch (selection)
                {
                    case 1:
                        Console.Write("Play Blackjack not yet implemented.");
                        break;
                    case 2:
                        Console.Write("Shuffle Hand & Show Deck not yet implemented.");
                        deck.Shuffle();
                        for (int i = 1; i <= 7; i+=2)
                        {
                            for (int j = 1; j <= 104; j+=8)
                            {
                                deck.Deal();
                                
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Sample Hands not yet implemented.");
                        break;
                    case 4:
                        Console.Write("Exit");
                        menuRun = false;
                        break;
                }

            }
        }
    }
}
