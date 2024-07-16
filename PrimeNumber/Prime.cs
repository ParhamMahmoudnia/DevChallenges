using System;

namespace PrimeNumber
{
    public class Prime
    {
        /// <summary>
        /// Checks if a given number is a prime number.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is prime, otherwise false.</returns>
        public static bool IsPrime(int number)
        {
            // 1 and numbers less than or equal to 1 are not prime
            if (number <= 1)
                return false;

            // 2 is a prime number
            if (number == 2)
                return true;

            // Even numbers greater than 2 are not prime
            if (number % 2 == 0)
                return false;

            // Check for odd factors from 3 up to the square root of the number
            // We increment by 2 to check only odd numbers
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
