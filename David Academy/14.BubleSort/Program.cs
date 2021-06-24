using System;

namespace _14.BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort:");
            Console.WriteLine();

            Console.WriteLine("Please enter size:");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine($"Enter {size} numbers:");
            for(int i =0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

           bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for(int i = 1; i < size; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                        swapped = true;
                    }
                }
            }
            Console.WriteLine("Result :");
            for(int i =0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
