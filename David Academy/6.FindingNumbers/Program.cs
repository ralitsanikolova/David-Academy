using System;

namespace _6.FindingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding numbers:");
            Console.WriteLine();

            double number = double.Parse(Console.ReadLine());
            var prime = true;

            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            for (int i = 0; i >= number; i--)
            {
                Console.WriteLine(number);
            }
        }
    }
}

