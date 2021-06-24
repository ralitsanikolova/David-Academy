using System;

namespace _4.FormatFractionalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Format Fractional Number");
            Console.WriteLine();

            Console.WriteLine("Please type a number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert fraction:");
            int fraction = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number is {number},{fraction}");

        }
    }
}
