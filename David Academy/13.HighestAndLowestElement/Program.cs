using System;

namespace _13.HighestAndLowestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Highest and lowest element");
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers:");
            var sum = 0;
            var max = int.MinValue;
            var min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Average =  {sum / n}");
            Console.WriteLine($"Max = {max}");
        }


    }
}
