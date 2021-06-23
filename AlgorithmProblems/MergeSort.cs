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
            int low = 0, high = array.Length - 1;
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
            if (low < high)
            {
                mid = low + (high - low) / 2;
                MergeSorting(array, low, mid);
                MergeSorting(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
            return array;
        }
        /// <summary>
        /// merging the arrays and sorting them
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static string[] Merge(string[] arr, int low, int mid, int high)
        {
            
            int n1 = mid - low + 1;
            int n2 = high - mid;

            string[] a = new string[n1];
            string[] b = new string[n2];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                a[i] = arr[low + i];
            }

            for (j = 0; j < n2; j++)
            {
                b[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = low;

            while (i < n1 && j < n2)
            {
                if (a[i].CompareTo(b[j]) < 0)
                {
                    arr[k] = a[i];
                    k++; i++;
                }
                else
                {
                    arr[k] = b[j];
                    k++; j++;
                }
            }

            while (i < n1)
            {
                arr[k] = a[i];
                k++; i++;
            }
            while (j < n2)
            {
                arr[k] = b[j];
                k++; j++;
            }
            return arr;
        }
    }
}