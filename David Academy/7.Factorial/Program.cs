using System;

namespace _7.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Factorial: ");
            Console.WriteLine();

            Console.Write("Please enter number :");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The result is = {factorial}");
        }
    }
}
