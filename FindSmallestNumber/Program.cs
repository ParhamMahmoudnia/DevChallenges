namespace FindSmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the input
            Console.WriteLine("Please enter a series of integers separated by spaces:");
            string input = Console.ReadLine();

            // Split the input string into an array of strings
            string[] inputStrings = input.Split(' ');

            // Convert the array of strings to an array of integers
            int[] numbers = Array.ConvertAll(inputStrings, int.Parse);

            // Find the smallest number in the array
            int smallestNumber = SmallestNumberFinder.FindSmallest(numbers);

            // Print the smallest number
            Console.WriteLine($"The smallest number in the array is: {smallestNumber}");

            // Wait for user input before closing console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}