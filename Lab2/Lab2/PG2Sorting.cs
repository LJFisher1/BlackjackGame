using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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



        public static void PrintList(List<string> unsorted, List<string> sorted)
        {
            Console.Clear();
            Console.WriteLine("--------UNSORTED--------                       --------SORTED--------");
            for (int i = 0; i < unsorted.Count; i++)
            {
                Console.WriteLine($"{unsorted[i],-45} {sorted[i]} ");
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


        public static List<string> BubbleSort(List<string> bubbleString) // Also need to clone the list so you can show unsorted next to the sorted
        {
            List<string> sortedList = bubbleString.ToList();
            int bubbleLength = sortedList.Count;
            string temp;
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 1; i <= bubbleLength - 1; i++)
                {
                    int compareResult = sortedList[i - 1].CompareTo(sortedList[i]); // -1 = less than, 0 = equals, 1 = greater than
                    if (compareResult == 1)// If the first element > the second element
                    {
                        temp = sortedList[i - 1];
                        sortedList[i - 1] = sortedList[i];
                        sortedList[i] = temp;
                        // You swap the elements in the loop (bubbleString[], i - 1, i)
                        swapped = true; // and set swapped = true;
                    }
                    // end the if loop
                } // end the for loop
                bubbleLength--;
                // n:= n-1   decrement the element being compared by 1 so it doesn't skip anything
            } while (swapped);
            return sortedList;
        }


        public static List<string> MergeSort(List<string> mergeString)
        {
            List<string> sortedList = mergeString.ToList();
            if (sortedList.Count <= 1)
            {
                return sortedList;
            }
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (i < sortedList.Count / 2)
                {
                    left.Add(sortedList[i]);
                }
                else
                {
                    right.Add(sortedList[i]);
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
        // BinarySearch(A[0..N - 1], searchTerm, low, high)
        public static int BinarySearch(List<string> unsorted, string searchTerm, int lowNdx, int highNdx)
        {
            List<string> binaryList = unsorted.ToList();
            binaryList = BubbleSort(binaryList);
            // if (high < low)
            if (highNdx < lowNdx)
            {//return -1 // -1 means not found
                return -1;
            }
            // mid = (low + high) / 2
            int mid = (lowNdx + highNdx) / 2;
            // if (searchTerm < A[mid])
            int compareResult = searchTerm.CompareTo(binaryList[mid]);
            if (compareResult == -1)
            {// return BinarySearch(A, searchTerm, low, mid - 1)
                return BinarySearch(binaryList, searchTerm, lowNdx, mid - 1);
            }// else if (searchTerm > A[mid])
            else if (compareResult == 1)
            {// return BinarySearch(A, searchTerm, mid + 1, high)
                return BinarySearch(binaryList, searchTerm, mid + 1, highNdx);
            }// else return mid //the searchTerm was found
            else
            {
                return mid;
            }


        }
        public static void Save(List<string> unsortedList)
        {
            List<string> saveFile = unsortedList.ToList();
            saveFile = BubbleSort(saveFile);
            string filePath = "";
            PG2Input.Input.ReadString("What do you want to name your file?", ref filePath);
            filePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jtw, saveFile);
                }
            }
        }

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


