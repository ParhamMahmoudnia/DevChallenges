namespace BinaryToDecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the input
            Console.WriteLine("Please enter a binary number:");
            string binaryInput = Console.ReadLine();

            // Convert the binary number to decimal
            int decimalOutput = BinaryToDecimalConverter.ConvertBinaryToDecimal(binaryInput);

            // Print the decimal number
            Console.WriteLine($"The decimal equivalent of binary {binaryInput} is: {decimalOutput}");

            // Wait for user input before closing console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}