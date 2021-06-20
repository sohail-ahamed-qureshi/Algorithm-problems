using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    /// <summary>
    /// Find your number using Binary search.
    /// </summary>
    class FindNumber
    {
        /// <summary>
        /// Search number function to find the number that is selected by the user.
        /// using binary search approach we do following opertion.
        /// </summary>
        /// <param name="number">argument user has sent used only to compare</param>
        /// <param name="low">Lower bound of range</param>
        /// <param name="high">Upper bound of range</param>
        /// <returns></returns>
        internal int SeachNumber(int number, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (number == mid)
                {
                    Console.WriteLine($"{mid} is the magic number");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"Is number greater than {mid}? Press Y --> Yes \n \t\t\t Press N --> No");
                    char input = Convert.ToChar(Console.ReadLine());
                    input = Char.ToUpper(input);
                    switch (input)
                    {
                        case 'Y':
                            low = mid + 1;
                            return SeachNumber(number, low, high);
                        case 'N':
                            high = mid - 1;
                            return SeachNumber(number, low, high);
                        default:
                            Console.WriteLine("Invalid option entered.");
                            break;
                    }
                }
            }
            Console.WriteLine("OOPS!!! number not found.");
            return -1;
        }
    }
}
