using System;

namespace AlgorithmProblems
{
    internal class PrimeNumbers
    {
        /// <summary>
        /// to print the prime numbers in the range.
        /// </summary>
        internal static void Print()
        {
            long range = 1000;
            int isPrime;
            int i;
            int[] primeArray = new int[170];
            Console.WriteLine("Prime Numbers");
            if (range <= 1)
                Console.WriteLine("Invalid Number");
            else
            {
                for (i = 1; i < range; i++)
                {
                    int counter = 0;
                    for (int j = i; j >= 1; j--)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        isPrime = i;
                        //check prime number is palindrome.
                        bool isPalindrome = CheckPalindrome(isPrime);
                        if (isPalindrome)
                            Console.WriteLine($"Prime and Palindrome: {isPrime}");
                    }
                }
            }
        }
        /// <summary>
        /// Perform palindrome check if number is palindrome then
        /// returns true else false.
        /// </summary>
        /// <param name="num">prime number is input</param>
        /// <returns></returns>
        internal static bool CheckPalindrome(int num)
        {
            int reverse = 0;
            int checkNum = num;
            //palindrome number should be atleast 2digit number
            if (num <= 10)
            {
                return false;
            }
            else
            {
                while (num > 0)
                {
                    int lastdigit = (num % 10);
                    reverse = (reverse * 10) + lastdigit;
                    num /= 10;
                }
                if (checkNum == reverse)
                    return true;
                else
                    return false;
            }
        }
    }
}