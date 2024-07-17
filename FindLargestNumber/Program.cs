namespace FindLargestNumber
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

            // Find the largest number in the array
            int largestNumber = LargestNumberFinder.FindLargest(numbers);

            // Print the largest number
            Console.WriteLine($"The largest number in the array is: {largestNumber}");

            // Wait for user input before closing console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}