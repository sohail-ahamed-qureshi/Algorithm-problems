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
            Console.WriteLine("Prime Numbers");
            if(range <= 1)
                Console.WriteLine("Invalid Number");
            else
            {
                for (int i = 1; i <= range; i++)
                {
                    int counter = 0;
                    for(int j =i; j >= 1; j--)
                    {
                        if(i%j == 0)
                        {
                            counter++;
                        }
                    }
                    if(counter == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}