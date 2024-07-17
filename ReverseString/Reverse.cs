using System;

namespace ReverseString
{
    public class Reverse
    {
        /// <summary>
        /// Reverses the input string.
        /// </summary>
        /// <param name="input">The string to reverse.</param>
        /// <returns>The reversed string.</returns>
        public static string ReverseString(string input)
        {
            // Create a new char array with the same length as the input string
            char[] originalChars = input.ToCharArray();

            // Create a temporary char array to store the reversed characters
            char[] reversedChars = new char[input.Length];

            // Iterate over the input string from the end to the beginning
            for (int i = input.Length - 1, j = 0; i >= 0 && j < input.Length; i--, j++)
            {
                reversedChars[j] = originalChars[i]; // Assign each character from the end of the input string to the beginning of the temp array
            }

            // Convert the reversed char array back to a string and return it
            return new string(reversedChars);
        }
    }
}
