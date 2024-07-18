using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    public class DecimalToBinaryConverter
    {

        public static string ConvertDecimalToBinary(int decimalNumber)
        {
            // If the input number is 0, return "0"
            if (decimalNumber == 0)
                return "0";

            string binaryResult = string.Empty;
            while (decimalNumber > 0)
            {
                // Find the remainder when decimalNumber is divided by 2
                int remainder = decimalNumber % 2;

                // Prepend the remainder to the result string
                binaryResult = remainder + binaryResult;

                // Divide the number by 2 for the next iteration
                decimalNumber /= 2;
            }

            return binaryResult;
        }
}
