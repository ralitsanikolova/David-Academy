using System;

namespace _3.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap year:");
            Console.WriteLine();

            Console.Write("Enter year:");
            int year = Int32.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year!");
            }
            else
            {
                Console.WriteLine("Not Leap Year.");
            }

        }
    }
}
