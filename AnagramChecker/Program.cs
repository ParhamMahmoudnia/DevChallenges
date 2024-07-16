namespace AnagramChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first word
            Console.Write("Please enter your first word: ");
            string firstWord = Console.ReadLine();

            // Prompt the user to enter the second word
            Console.Write("Please enter your second word: ");
            string secondWord = Console.ReadLine();

            // Check if the two words are anagrams using the IsAnagram method from the Anagram class
            bool isAnagram = Anagram.IsAnagram(firstWord, secondWord);

            // Display the result based on whether the words are anagrams or not
            if (isAnagram)
            {
                Console.WriteLine($"\"{firstWord}\" and \"{secondWord}\" are anagrams.");
            }
            else
            {
                Console.WriteLine($"\"{firstWord}\" and \"{secondWord}\" are not anagrams.");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
