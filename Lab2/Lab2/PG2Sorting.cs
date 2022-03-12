using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    public static class PG2Sorting
    {
        //        Load the file
        //Write a METHOD to read the file and return a list of strings. Open and read the line from the inputFile.csv file. The
        //line in the file contains a list of comic book titles separated by commas. Split the string and store each title in a List
        //of strings.
        //    COMMON MISTAKES: 
        //-2: you have a full or relative path to the file that is specific to your machine
        //-2: you are not closing the file after you read it
        //-2: you are not parsing the data correctly
        //-1: you are not cloning the original correctly.Setting List<string> list2 = list1; only points list2 to the same thing that
        //list1 points to.
        //-1: not converting the array to a list.
        //-2: did not create a METHOD for reading the file
        public static void PrintList(List<string> A, List<string> B)
        {
            Console.Clear();
            Console.WriteLine("--------UNSORTED--------                       --------SORTED--------");
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine($"{A[i],-45} {B[i]} ");
            }
        }

        public static List<string> ReadFile()
        {
            List<string> comicBooks = new List<string>();

            using (StreamReader reader = new StreamReader("inputFile.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] cb = line.Split(new char[] { ',' });
                    comicBooks = cb.ToList();
                }
            }
            return comicBooks;
        }

        //ALL METHODS MUST BE IN THE PG2SORTING.CS FILE


        //        Bubble Sort
        //Write a METHOD to implement the Bubble sort algorithm.You want to keep the original list unsorted so make sure
        //to clone the original list each time you call the Bubble sort.Your code must follow the pseudocode.
        //Turn this Wikipedia pseudocode into C#:
        //procedure bubbleSort(A : list of sortable items)
        // n := length(A)
        // repeat
        // swapped := false
        // for i := 1 to n - 1 inclusive do
        // if A[i - 1] > A[i] then
        // swap(A, i - 1, i)
        // swapped = true
        // end if
        // end for
        // n := n - 1
        // while swapped
        //end procedure
        //NOTE: swap is a METHOD that is not provided by C#. You can create your own METHOD or you can insert the swap 
        //logic inside the if. See the lectures slides for how to swap 2 items in a list
        public static void BubbleSort(List<string> bubbleString) // Also need to clone the list so you can show unsorted next to the sorted
        {
            int bubbleLength = bubbleString.Count;
            string temp;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= bubbleLength - 1; i++)
                {
                    int compareResult = bubbleString[i - 1].CompareTo(bubbleString[i]); // -1 = less than, 0 = equals, 1 = greater than
                    if (compareResult == 1)// If the first element > the second element
                    {
                        temp = bubbleString[i - 1];
                        bubbleString[i - 1] = bubbleString[i];
                        bubbleString[i] = temp;
                        // You swap the elements in the loop (bubbleString[], i - 1, i)
                        swapped = true; // and set swapped = true;
                    }
                    // end the if loop
                } // end the for loop
                bubbleLength--;
                // n:= n-1   decrement the element being compared by 1 so it doesn't skip anything
            } while (swapped);

        }

        // start by dividing the list into sublists that only have 1 element in them
        // then merge the individiual items into sorted lists
        // continue merging until there is only one list

        public static List<string> MergeSort(List<string> mergeString)
        {
            if (mergeString.Count <= 1)
            {
                return mergeString;
            }
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            for (int i = 0; i < mergeString.Count; i++)
            {
                if (i < mergeString.Count / 2)
                {
                    left.Add(mergeString[i]);
                }
                else
                {
                    right.Add(mergeString[i]);
                }
                left = MergeSort(left);
                right = MergeSort(right);
            }
            return Merge(left, right);
        }
        public static List<string> Merge(List<string> left, List<string> right)
        {
            List<string> result = new List<string>();
            while (left.Count > 0 && right.Count > 0)
            {
                int compareResult = left[0].CompareTo(right[0]);
                if (compareResult == -1)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
            return result;
        }

        public static void BinarySearch(List<string> unsorted)
        {
            List<string> sorted = MergeSort(unsorted);
        }
        //        Binary Search
        //Write a METHOD to implement the Binary Search algorithm(use a recursive approach). Your code must follow the
        //pseudocode.
        //1. Clone the original list and sort the cloned list (call Sort on the list).
        //2. Loop over the sorted list.
        //3. Call your binary search METHOD to search the sorted list for each title in the sorted list.
        //HINT: the index returned from your binary search should match the index.
        //Show the search title, the index and the index returned by your binary search METHOD.
        //            Turn this Wikipedia pseudocode into C#:
        //// initially called with low = 0, high = N-1. A is a sorted list.
        // BinarySearch(A[0..N - 1], searchTerm, low, high) {
        //            if (high < low)
        //                return -1 // -1 means not found
        // mid = (low + high) / 2
        // if (searchTerm < A[mid])
        //                return BinarySearch(A, searchTerm, low, mid - 1)
        // else if (searchTerm > A[mid])
        // return BinarySearch(A, searchTerm, mid + 1, high)
        // else
        //                return mid //the searchTerm was found

        //        COMMON MISTAKES: 
        //-10: did not follow the pseudo-code for binary search
        //-1: in Binary Search, you should only call the CompareTo METHOD once and store the result instead of calling it
        //twice.
        //-1: Binary Search should return the index if found or -1 if not found
        //-5: binary search code was not modified to work with strings and doesn’t return the correct index.
        //-2: the binary search needs an exit condition for when min > max.If this condition happens, then you need to 
        //return -1 to indicate that the search item was not found.You should check the condition at the top of the binary
        //search METHOD.
        //-2: in binary search, you need to calculate the mid like this: min + (max – min)/2 OR(max + min) / 2.
        //-2: when recursively calling binary search, you need to do mid+1 or min-1 so you are not re-evaluating the mid
        //point again.
        //-2: the lab requirements for binary search were to loop over the sorted list and call your binary search for each
        //item in the list.Print the word, the index, and the index returned from your binary search.
        //-2: did not write a METHOD for Binary Search

        //        NuGet & Json.NET

        //NuGet is the package manager for .NET – it’s a place to grab helpful code from 3rd parties.For this lab, you’ll need
        //to use NuGet to grab Json.NET.
        //To add a reference to Json.NET, right-click the References node under your class library project and select 
        //“Manage NuGet Packages…”. Select the “Browse” link in the top-left of the page that is loaded in the IDE.Enter
        //“Newtonsoft.Json” in the search box.Select the item in the list of search results and in the right panel of the page,
        //select Install. 

        //        Save
        //        Now you have the information you need to add logic to the menu for the “Save” option.Write a METHOD to
        //serialize a sorted list to a save file.Take a clone of the unsorted, sort using one of your sort algorithms, then save
        //the sorted list to a json file.
        //• Ask the user for the name of the save file. Use ReadString to get the name of the file.
        //• If the name does not have the json extension, add it to the file name. Look at the Path METHODs
        //GetExtension, HasExtension, and ChangeExtension to make sure you get the extension set correctly.
        //• You will need to serialize the list in JSON format. Use the JSON.net library.

        //        COMMON MISTAKES: 
        //• -2: not using ReadString to get the file name from the user
        //• -2: not ensuring the filename has a.json extension.
        //• -2: not changing the extension correctly
        //• -4: not serializing a sorted list
        //• -4: not serializing in JSON format
        //• -2: did not write a METHOD for saving the data


    }
}

