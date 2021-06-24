using System;

namespace _11._Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine();

            bool startAgain = true;
            while (startAgain)
            {
                Console.Write("Please enter first number:");
                double numberOne = double.Parse(Console.ReadLine());

                Console.Write("Please enter second number:");
                double numberTwo = double.Parse(Console.ReadLine());

                Console.Write("Please enter operator:");
                string operation = Console.ReadLine();

                double result;
                switch (operation)
                {
                    case "+":
                        result = numberOne + numberTwo;
                        break;

                    case "-":
                        result = numberOne - numberTwo;
                        break;

                    case "*":
                        result = numberOne * numberTwo;
                        break;

                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed!");
                            return;
                        }
                        else
                        {
                            result = numberOne / numberTwo;
                        }
                        break;

                    default:
                        Console.WriteLine("This operator is not supported.");
                        return;
                }

                Console.WriteLine($"Result = {result}");
            }
        }
    }
}
