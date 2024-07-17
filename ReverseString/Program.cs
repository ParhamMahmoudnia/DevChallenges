namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string to reverse
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            // Reverse the input string
            string reversedString = Reverse.ReverseString(input);

            // Display the reversed string
            Console.WriteLine($"Reversed string: {reversedString}");

            // Wait for user input before closing console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}