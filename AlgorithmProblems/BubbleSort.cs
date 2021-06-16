using System;

namespace AlgorithmProblems
{
    internal class BubbleSort
    {
        internal static void Sorting()
        {
            int[] array = { 20, 14, 3, 7, 2 };
            Console.WriteLine("Unsorted array");
            Display(array);
            int[] sortedArray =Sort(array);
            Console.WriteLine("Sorted array");
            Display(sortedArray);
        }
        /// <summary>
        /// sorting an array using bubble sort, returns a sorted array
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <returns></returns>
        private static int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int firstItr = 0; firstItr < length; firstItr++)
            {
                //flag to check if any swapping is done.
                int flag = 0;
                for (int secondItr = 0; secondItr < length-1-firstItr; secondItr++)
                {
                    if(array[secondItr] > array[secondItr + 1])
                    {
                        int temp = array[secondItr];
                        array[secondItr] = array[secondItr + 1];
                        array[secondItr + 1] = temp;
                        flag++;
                    }
                }
                //if no swap is done then array is sorted.
                if(flag == 0)
                {
                    break;
                }
            }
            return array;
        }
        /// <summary>
        /// method to display an array
        /// </summary>
        /// <param name="array"></param>
        private static void Display(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}