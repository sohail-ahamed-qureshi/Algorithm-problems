using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class InsertionSort
    {
        /// <summary>
        /// Utility method to perform Sorting an array...
        /// </summary>
        internal static void Sorting()
        {
            string[] array = { "Zoo","hello", "hi", "how", "are", "you", "sohail","Bye",  };
            Console.WriteLine("Unsorted Array");
            Display(array);
            Console.WriteLine("Sorted array....");
            string[] sortedArray = InsertSort(array);
            Display(sortedArray);
        }
        /// <summary>
        /// method to Display an array 
        /// </summary>
        /// <param name="sortedArray"></param>
        private static void Display(string[] Array)
        {
            foreach (string item in Array)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Method to perform Insertion Sort, returns an sorted array
        /// </summary>
        /// <param name="array"> input array to be sorted</param>
        /// <returns></returns>
        private static string[] InsertSort(string[] array)
        {
            for (int secondElement = 1; secondElement < array.Length; secondElement++)
            {
                string temp = array[secondElement];
                int prevElement = secondElement - 1;
                while(prevElement >= 0 && array[prevElement].CompareTo(temp) > 0)
                {
                    array[prevElement+1] = array[prevElement];
                    prevElement--;
                }
                array[prevElement + 1] = temp;
            }
            return array;
        }
    }
}
