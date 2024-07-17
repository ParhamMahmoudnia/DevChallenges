using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculation
{
    public class Factorial
    {

        public static BigInteger CalculateFactorial(int number)
        {
            // Check if the input number is valid
            if (number < 0)
                throw new ArgumentException("Input must be a non-negative integer.", nameof(number));

            // Return 1 for 0 and 1 directly
            if (number == 0 || number == 1)
                return 1;

            // Initialize factorial as BigInteger to handle large numbers
            BigInteger factorial = 1;

            // Calculate factorial using a loop from 2 to number
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
