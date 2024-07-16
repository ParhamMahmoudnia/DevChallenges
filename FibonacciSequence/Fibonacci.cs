using System.Numerics;

namespace FibonacciSequence
{
    public class Fibonacci
    {
        /// <summary>
        /// Generates a Fibonacci sequence of a given length.
        /// </summary>
        /// <param name="length">The length of the Fibonacci sequence to generate.</param>
        /// <returns>A string representation of the Fibonacci sequence.</returns>
        public static string GenerateFibonacci(int length)
        {
            // Initialize the array to hold the Fibonacci sequence values
            BigInteger[] fibonacciArray = new BigInteger[length];

            // Set the first two values in the sequence
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            // Compute the remaining values in the sequence
            for (int i = 2; i < length; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }

            // Join the array values into a comma-separated string and return
            return string.Join(", ", fibonacciArray);
        }
    }
}
