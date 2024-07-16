using System;

namespace PalindromeChecker
{
    // Solution 1: Check if a string is a palindrome
    public class Palindrome
    {
        // Method to check if input string is a palindrome
        public static bool IsPalindrome(string input)
        {
            string processedInput = Preprocess(input);

            int leftIndex = 0;  // Start from the beginning of the string
            int rightIndex = processedInput.Length - 1;  // Start from the end of the string

            // Iterate through the string until the two pointers meet
            while (leftIndex < rightIndex)
            {
                // Compare characters from both ends of the string
                if (processedInput[leftIndex] != processedInput[rightIndex])
                {
                    return false;   // If characters do not match, it's not a palindrome
                }

                leftIndex++;    // Move the left pointer to the right
                rightIndex--;   // Move the right pointer to the left
            }

            return true;    // If all characters match, it's a palindrome
        }

        // Method to preprocess input string: convert to lowercase
        private static string Preprocess(string input)
        {
            input = input.ToLower();    // Convert input string to lowercase

            return input;   // Return the preprocessed string
        }
    }

    // Solution 2: Check if a string is a palindrome (commented out for reference)

    //public class Palindrome
    //{
    //    // Method to check if input string is a palindrome
    //    public static bool IsPalindrome(string input)
    //    {
    //        string processedInput = Preprocess(input);

    //        char[] characters = processedInput.ToCharArray();

    //        Array.Reverse(characters);

    //        string reversedString = new string(characters);

    //        return processedInput == reversedString;
    //    }

    //    // Method to preprocess input string: convert to lowercase
    //    private static string Preprocess(string input)
    //    {
    //        input = input.ToLower();    // Convert input string to lowercase

    //        return input;   // Return the preprocessed string
    //    }
    //}

}