using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BinarySearchWord
    {
        /// <summary>
        /// Binary search Utility method
        /// </summary>
        public static void BinarySearch()
        {
            string[] array =  { "hello", "hi", "how", "are", "you", "sohail" };
            Console.WriteLine("Sorting array....");
            string[] sortedArray = SortingArray(array);
            DisplayArr(sortedArray);
            Console.WriteLine("Enter the string to be found:");
            string searchWord = Console.ReadLine();
           int index = BinSearchWord(searchWord, sortedArray);
            if(index == -1)
                Console.WriteLine($"{searchWord} not found in wordlist");
            else
                Console.WriteLine($"{searchWord} is found at index : {index} ");
        }
        /// <summary>
        /// Binary Search method for a string, return the index of search word if found
        /// else returns -1.
        /// </summary>
        /// <param name="searchWord">word to be searched in the wordlist</param>
        /// <param name="sortedArray">array of words from the wordlist which are sorted</param>
        /// <returns></returns>
        private static int BinSearchWord(string searchWord, string[] sortedArray)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (sortedArray[mid] == searchWord)
                    return mid;
                else if (searchWord.CompareTo(sortedArray[mid]) > 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
        /// <summary>
        /// Manually sorting an array as Binary search works only for sorted arrays.
        /// returns an sorted array of list
        /// </summary>
        /// <param name="array">unsorted array to be sorted</param>
        /// <returns></returns>
        private static string[] SortingArray(string[] array)
        {
            int size = array.Length;
            for(int firstWord =0; firstWord < size-1; firstWord++)
            {
                for(int secondWord =firstWord+1; secondWord<array.Length; secondWord++)
                {
                    if(array[firstWord].CompareTo(array[secondWord]) > 0)
                    {
                        string temp = array[firstWord];
                        array[firstWord] = array[secondWord];
                        array[secondWord] = temp;
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// method to display an array
        /// </summary>
        /// <param name="array"></param>
        private static void DisplayArr(string[] array)
        {
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
        }
    }
}
