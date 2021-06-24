using System;

namespace _8.Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonachi search:");
            Console.WriteLine();

            Console.WriteLine("Please enter number:");
            int number = int.Parse(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;

                for(int i = 0; i< number - 1; i++)
            {
                int nextFib = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextFib;
            }
            Console.WriteLine($"The Fibonaci number is {fib2}");
        }
    }
}
