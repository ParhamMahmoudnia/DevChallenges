using System;

namespace AnagramChecker
{
    public class Anagram
    {
        /// <summary>
        /// Checks if two input strings are anagrams of each other.
        /// </summary>
        /// <param name="firstWord">The first word to check.</param>
        /// <param name="secondWord">The second word to check.</param>
        /// <returns>True if the strings are anagrams, false otherwise.</returns>
        public static bool IsAnagram(string firstWord, string secondWord)
        {
            // Check if the lengths of the two words are different
            if (firstWord.Length != secondWord.Length)
                return false;

            // Preprocess both words by converting them to lowercase
            string processedFirstWord = ToLowercase(firstWord);
            string processedSecondWord = ToLowercase(secondWord);

            // Convert the first processed word to a character array
            char[] firstWordChars = processedFirstWord.ToCharArray();

            // Check each character of the first processed word
            // to see if it exists in the second processed word
            for (int i = 0; i < processedFirstWord.Length; i++)
            {
                bool contains = processedSecondWord.Contains(firstWordChars[i]);

                // If a character does not exist in the second word, return false
                if (!contains)
                {
                    return false;
                }
            }

            // If all characters are found in the second word, they are anagrams
            return true;
        }

        /// <summary>
        /// Converts the input string to lowercase.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        /// <returns>The input string converted to lowercase.</returns>
        private static string ToLowercase(string input)
        {
            input = input.ToLower();    // Convert input string to lowercase
            return input;   // Return the preprocessed string
        }
    }
}
