using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is prime: ");
            int input = int.Parse(Console.ReadLine());

            bool isPrime = Prime.IsPrime(input);

            Console.WriteLine($"Is {input} a prime number? {isPrime}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();  // Wait for user input before closing console
        }
    }
}
