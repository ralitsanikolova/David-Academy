using System;

namespace _20.ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Numbers:");

            int size;
            Console.WriteLine("Please enter size:");
            size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine($"Enter {size} numbers:");
            for(int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i =0 ; i < size / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[size - i - 1];
                numbers[size - i - 1] = temp;
            }

            Console.WriteLine("Result:");
            for(int i = 0; i <size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
