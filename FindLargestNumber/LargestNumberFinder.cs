using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumber
{
    public class LargestNumberFinder
    {
        /// <summary>
        /// Finds the largest number in an array of integers.
        /// </summary>
        /// <param name="numbers">The array of integers to search through.</param>
        /// <returns>The largest integer in the array.</returns>
        public static int FindLargest(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("The array must contain at least one element.");

            int largest = numbers[0];

            // Iterate through the array to find the largest number
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i]; // Update the largest number
                }
            }

            return largest;
        }
    }
}
