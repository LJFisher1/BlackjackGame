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
            List<string> comicList = PG2Sorting.ReadFile();
            List<string> bubbleSorted = PG2Sorting.BubbleSort(comicList);
            List<string> mergeSorted = PG2Sorting.MergeSort(comicList);
           


            bool menuRun = true;
            string choice = "Pick a choice: ";
            string[] options = { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit" };
            while (menuRun)
            {
                Input.ReadChoice(choice, options, out int selection);
                Console.Clear();
                switch (selection)
                {
                    
                    case 1:
                        List<string> afterBubbleSort = PG2Sorting.BubbleSort(comicList);
                        PG2Sorting.PrintList(comicList, afterBubbleSort);
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        List<string>afterMergeSort = PG2Sorting.MergeSort(comicList);
                        PG2Sorting.PrintList(comicList, afterMergeSort);
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        for (int i = 0; i < comicList.Count; i++)
                        {
                            int retNdx = PG2Sorting.BinarySearch(bubbleSorted, bubbleSorted[i], 0, comicList.Count);
                            Console.Write(bubbleSorted[i]);
                            Console.CursorLeft = 45;
                            Console.WriteLine($"    Index: {i} \t\t Returned Index: {retNdx}");
                        }
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
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
