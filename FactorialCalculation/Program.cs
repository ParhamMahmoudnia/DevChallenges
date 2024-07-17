using System.Numerics;

namespace FactorialCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = Factorial.CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is: {factorial}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}