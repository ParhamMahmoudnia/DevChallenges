namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your word: ");
            string input = Console.ReadLine();  // Read input from console

            bool isPalindrome = Palindrome.IsPalindrome(input);  // Check if input is a palindrome

            if (isPalindrome)
            {
                Console.WriteLine($"\"{input}\" is a palindrome.");  // Print message if palindrome
            }
            else
            {
                Console.WriteLine($"\"{input}\" is not a palindrome.");  // Print message if not palindrome
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();  // Wait for user input before closing console
        }
    }
}