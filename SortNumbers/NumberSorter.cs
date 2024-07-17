using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class NumberSorter
    {
        // Bubble Sort algorithm to sort an array of numbers
        public static int[] ReturnSorted(int[] numbers)
        {
            int n = numbers.Length;

            // Outer loop for passes
            for (int i = 0; i < n - 1; i++)
            {
                // Inner loop for comparisons
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the current element is greater than the next element
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
