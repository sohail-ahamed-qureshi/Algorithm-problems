using System;

namespace AlgorithmProblems
{
    internal class MergeSort
    {
        internal static void Sorting()
        {
            string[] array = { "Zoo", "hello", "hi", "how", "are", "you", "sohail", "Bye" };
            Console.WriteLine("Unsorted Array");
            InsertionSort.Display(array);
            Console.WriteLine("Sorted array....");
            int low = 0, high = array.Length-1;
             MergeSorting(array, low, high);
            InsertionSort.Display(array);
        }
        /// <summary>
        /// Merge sorting an array - first the division is done and sorting is done.
        /// returns an sorted array of string.
        /// </summary>
        /// <param name="array">input array to be sorted</param>
        /// <param name="low">lower bound of an array</param>
        /// <param name="high">upper bound of an array</param>
        /// <returns></returns>
        private static string[] MergeSorting(string[] array, int low, int high)
        {
            int mid;
            string[] mergeArr = new string[8];
            if (low < high)
            {
                mid = low +(high - low) / 2;
                MergeSorting(array, low, mid);
                MergeSorting(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
            return array;
        }

        private static string[] Merge(string[] array, int low, int mid, int high)
        {
            int ithElement = low;
            int jthElement = mid +1;
            int kthElement = low;
            string[] mergedArray = new string[8];

            while (ithElement <= mid && jthElement <= high)
            {
                if ((array[ithElement].CompareTo(array[jthElement])) < 0)
                {
                    mergedArray[kthElement] = array[ithElement];
                    ithElement++;
                }
                else
                {
                    mergedArray[kthElement] = array[jthElement];
                    jthElement++;
                }
                kthElement++;
            }
            if (ithElement > mid)
            {
                while (jthElement <= high)
                {
                    mergedArray[kthElement] = array[jthElement];
                    jthElement++;
                    kthElement++;
                }
            }
            else
            {
                while (ithElement <= mid)
                {
                    mergedArray[kthElement] = array[ithElement];
                    ithElement++;
                    kthElement++;
                }
            }
            for (kthElement = low; kthElement < high; kthElement++)
            {
                array[kthElement] = mergedArray[kthElement];
            }
            return mergedArray;
        }
    }
}