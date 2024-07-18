namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the input
            Console.WriteLine("Please enter a decimal number:");
            int decimalInput = int.Parse(Console.ReadLine());

            // Convert the decimal number to binary
            string binaryOutput = DecimalToBinaryConverter.ConvertDecimalToBinary(decimalInput);

            // Print the binary number
            Console.WriteLine($"The binary equivalent of decimal {decimalInput} is: {binaryOutput}");

            // Wait for user input before closing console
            Console.ReadKey();
        }
    }
}