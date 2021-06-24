using System;

namespace _7._1_FactorialRecursivelyOrlteratively
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Factorial: ");
            Console.WriteLine();

            String command = "";

            while (!command.Equals("No"))
            {

                Console.Write("Please enter number :");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Please enter method :");
                string method = Console.ReadLine();
                int factorial = 1;
                switch (method)
                {
                    case "Recursively":
                        for (int i = 1; i <= number; i++)
                        {
                            factorial = number * (number - 1)!;
                        }
                        Console.WriteLine($"The result is = {factorial}");
                        break;

                    case "Iteratively":
                        for (int i = 1; i <= number; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine($"The result is = {factorial}");
                        break;
                }
                Console.WriteLine("Do you want to continue?");
                command = Console.ReadLine();

            }
        }
    }
}



