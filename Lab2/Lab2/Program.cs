using System;
using PG2Input;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //        The Menu
            //Show a menu to the user so they can select one of the algorithms(bubble, merge and binary search), save a sorted
            //list, and Exit. (Use the ReadChoice METHOD you created in the first lab) After calling any of the sorting METHODs, you
            //should display the unsorted list along with the sorted list.
            //1. Bubble Sort
            //2. Merge Sort
            //3. Binary Search
            //4. Save
            //5. Exit
            //            COMMON MISTAKES: 
            //-1: you should print the sorted results side-by-side with the unsorted
            //-3: the Exit option does not exit


            List<string> bubbleSortList = PG2Sorting.ReadFile();
            

            bool menuRun = true;
            string choice = "Pick a choice: ";
            string[] options = { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit" };
            while (menuRun)
            {
                Input.ReadChoice(choice, options, out int selection);
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        List<string> unsortedBubble = bubbleSortList.ToList();
                        PG2Sorting.BubbleSort(bubbleSortList);
                        for (int i = 0; i < bubbleSortList.Count; i++)
                        {
                            Console.Write(bubbleSortList[i]);
                            Console.CursorLeft = 45;
                            Console.WriteLine(unsortedBubble[i]);
                        }
                        


                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Merge sort not yet implemented.");
                        break;
                    case 3:
                        Console.Write("Binary search not yet implemented.");
                        break;
                    case 4:
                        Console.Write("Save not yet implemented.");
                        break;
                    case 5:
                        Console.Write("Exit");
                        menuRun = false;
                        break;
                }
            }
        }
    }
}
