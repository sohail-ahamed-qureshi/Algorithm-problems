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
            Console.WriteLine("Press 7 to print prime numbers that are Anagram and Palindrome in 0-1000 range");
            Console.WriteLine("Press 8 to Find the number.");
            Console.WriteLine("Press 9 to Customize message string using Regex.");
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
                case 7:
                    //prime numbers in 0 - 1000 range 
                    PrimeNumbers.Print();
                    break;
                case 8:
                    //Find your Number 
                    int number = Convert.ToInt32(args[0]);
                    FindNumber findNumber = new FindNumber();
                    findNumber.SeachNumber(number, 1, 100);
                    break;
                case 9:
                    //Customize Message Demonstration using string function and RegEx
                    string words = "Hello <<name>>,\nWe have your fullname as << full name >> in our system. \nYour contact number is 91 - xxxxxxxxxx. Please,let us know in case of any clarification \nThank you BridgeLabz 01 / 01 / 2016.";
                    Console.WriteLine(words);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to recorrect details? Press Y --> Yes \n Press N --> No  ");
                    char inp = Convert.ToChar(Console.ReadLine());
                    UserDetails userDetails = new UserDetails();
                    userDetails.UserChoice(inp);
                    break;
                default:
                    Console.WriteLine("invalid selection made!!");
                    Console.WriteLine("Enter a valid option: ");
                    break;
            }
        }
    }
}
