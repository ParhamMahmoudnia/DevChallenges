using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    public class BinaryToDecimalConverter
    {
        public static int ConvertBinaryToDecimal(string binaryInput)
        {
            // Create an array to hold each binary digit
            int[] binaryArray = new int[binaryInput.Length];

            // Fill the array with the digits of the binary number
            for (int i = 0; i < binaryInput.Length; i++)
            {
                binaryArray[i] = binaryInput[i] - '0'; // Convert char to int
            }

            int decimalValue = 0;

            // Iterate through the binary array to calculate the decimal value
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i] == 1)
                {
                    decimalValue += 1 << (binaryArray.Length - 1 - i); // 1 << (length - 1 - i) gives 2^(length - 1 - i)
                }
            }

            return decimalValue;
        }
    }
}
