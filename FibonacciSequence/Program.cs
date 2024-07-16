using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Fibonacci sequence: ");
            int length = int.Parse(Console.ReadLine());

            // Generate Fibonacci sequence
            string fibonacciSequence = Fibonacci.GenerateFibonacci(length);

            // Display the Fibonacci sequence to the user
            Console.WriteLine($"Fibonacci sequence of length {length}: {fibonacciSequence}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();  // Wait for user input before closing console
        }
    }
}
