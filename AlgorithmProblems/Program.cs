using System;

namespace AlgorithmProblems
{
    class Program
    {
        /// <summary>
        /// DS algorithm- Binary search a word from wordlist.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm problems");
            Console.WriteLine("Press 1 for Permutation problem statement");
            Console.WriteLine("Press 2 for Binary search in a word list");
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
                default:
                    Console.WriteLine("invalid selection made!!");
                    Console.WriteLine("Enter a valid option: ");
                    break;
            } 
        }
    }
}
