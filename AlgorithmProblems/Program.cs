using System;

namespace AlgorithmProblems
{
    class Program
    {
        /// <summary>
        /// DS algorithm- Anagram
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm problems");
            Console.WriteLine("Press 1 for Permutation problem statement");
            Console.WriteLine("Press 2 for Binary search in a word list");
            Console.WriteLine("Press 3 for Insertion sort to sort a word list");
            Console.WriteLine("Press 4 for Bubble sort to sort a Integer Array");
            Console.WriteLine("Press 5 for Merge sort to sort a list of Strings");
            Console.WriteLine("Press 6 check two strings are Anagram");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //permutation of a string using Iterative and Recursive method.
                    string input = "abc";
                    PermuteString.PermuteRecursive(input, "");
                    Console.WriteLine("-----------------------------");
                    PermuteString.PermuteIterative(input, 0, input.Length - 1);
                    break;
                case 2:
                    //binary search a word from word list
                    BinarySearchWord.BinarySearch();
                    break; 
                case 3:
                    //insertion sort 
                    InsertionSort.Sorting();
                    break;
                case 4:
                    //Bubble sort 
                    BubbleSort.Sorting();
                    break;
                case 5:
                    //Merge sort 
                    MergeSort.Sorting();
                    break;
                case 6:
                    //Anagram 
                    Anagram.CheckAnagram();
                    break;
                default:
                    Console.WriteLine("invalid selection made!!");
                    Console.WriteLine("Enter a valid option: ");
                    break;
            } 
        }
    }
}
