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
            bool swapped;
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
            PG2Input.Input.ReadString("What do you want to name your file? ", ref filePath);
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



}


