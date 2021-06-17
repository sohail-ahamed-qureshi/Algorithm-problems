using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class Anagram
    {
        internal static void CheckAnagram()
        {
            Console.WriteLine("Enter tw strings.");
            Console.WriteLine("string1 :");
            string firstWord = Console.ReadLine();
            Console.WriteLine("string2 :");
            string secondWord = Console.ReadLine();

            char[] frstArr = firstWord.ToLower().ToCharArray();
            char[] secondArr = secondWord.ToLower().ToCharArray();
            InsertSortChar(frstArr);
            InsertSortChar(secondArr);
            string val1 = new string(frstArr);
            string val2 = new string(secondArr);

            if(val1 == val2)
                Console.WriteLine($"{firstWord} and {secondWord} are Anagrams");
            else
                Console.WriteLine($"{firstWord} and {secondWord} are not Anagrams");
        }
        /// <summary>
        /// Insert sorting an array of char type returns an char array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static char[] InsertSortChar(char[] array)
        {
            for (int secondElement = 1; secondElement < array.Length; secondElement++)
            {
                char temp = array[secondElement];
                int prevElement = secondElement - 1;
                while (prevElement >= 0 && array[prevElement].CompareTo(temp) > 0)
                {
                    array[prevElement + 1] = array[prevElement];
                    prevElement--;
                }
                array[prevElement + 1] = temp;
            }
            return array;
        }
    }
}
