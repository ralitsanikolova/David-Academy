using System;

namespace _6.FindingPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string primeNumbers = "";
            bool prime = true;

            Console.Write("Enter value of n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                prime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                    Console.WriteLine("" + i);
            }
        }
    }
}

