using System;

namespace _9.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation:");
            Console.WriteLine();

            Console.WriteLine("The formula of the quadratic equation is ax^2 + bx + c = 0");

            Console.WriteLine("Input the value of a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the value of b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the value of c:");
            int c = int.Parse(Console.ReadLine());

            double x1, x2;

            Console.WriteLine("First we must find the discriminant.");
            int discr = b * b - 4 * a * c;

            if (discr < 0)
            {
                Console.WriteLine($"Discriminant = {discr}");
                Console.WriteLine("The equation has no solution!");
            }
            if (discr == 0)
            {
                Console.WriteLine($"Discriminant = {discr}");
                Console.WriteLine("There is one root");
                x1 = (-b) / (2.0 * a);
                x2 = x1;
                Console.WriteLine($"First root x1 = {x1}");
                Console.WriteLine($"Second root x2 = {x2}");

            }
            if (discr >= 1)
            {
                Console.WriteLine($"Discriminant = {discr}");
                Console.WriteLine("There is more than one root.");
                x1 = (-b + Math.Sqrt(discr)) / 2 * a;
                x2 = (-b - Math.Sqrt(discr)) / 2 * a;
                Console.WriteLine($"First root x1 = {x1}");
                Console.WriteLine($"Second root x2 = {x2}");
            }
        }
    }
}
