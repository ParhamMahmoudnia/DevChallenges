using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestNumber
{
    public class SmallestNumberFinder
    {
            /// <summary>
            /// Finds the smallest number in an array of integers.
            /// </summary>
            /// <param name="numbers">The array of integers to search through.</param>
            /// <returns>The smallest integer in the array.</returns>
            public static int FindSmallest(int[] numbers)
            {
                // Validate the input array
                if (numbers == null || numbers.Length == 0)
                    throw new ArgumentException("The array must contain at least one element.");

                int smallest = numbers[0]; // Assume the first element is the smallest

                // Iterate through the array to find the smallest number
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i]; // Update the smallest number
                    }
                }

                return smallest;
            }
    }
}
