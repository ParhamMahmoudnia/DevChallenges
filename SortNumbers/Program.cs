namespace SortNumbers
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

            // Sort the numbers using the NumberSorter class
            int[] sortedNumbers = NumberSorter.ReturnSorted(numbers);

            // Print the sorted numbers
            Console.WriteLine("The sorted list of numbers is:");
            foreach (int number in sortedNumbers)
            {
                Console.Write(number + " ");
            }

            // Wait for user input before closing console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}