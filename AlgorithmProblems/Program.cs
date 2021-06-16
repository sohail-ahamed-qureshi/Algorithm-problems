using System;

namespace AlgorithmProblems
{
    class Program
    {
        /// <summary>
        /// DS algorithm- find all permutations of string using iterative and recursive method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm problems");
            PermuteString permute = new PermuteString();
            string input = "abcd";
            PermuteString.PermuteRecursive(input, "");
            Console.WriteLine("-----------------------------");
            PermuteString.PermuteIterative(input, 0, input.Length - 1);
        }
    }
}
