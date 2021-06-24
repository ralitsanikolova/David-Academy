using System;

namespace _15._CountOfInversionsInArray
{
    class Program
    {
        static int[] arr = new int[] { 5, 8, 15, 14, 6, 1 };
        static int InversionCount(int numbers)
        {
            int invCount = 0;
            for (int i = 0; i < numbers - 1; i++)
            {
                for (int j = i + 1; j < numbers; j++)
                {
                    if (arr[i] > arr[j])
                        invCount++;
                }
            }
            return invCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Count of Inversions:");
            Console.WriteLine();

            Console.WriteLine($"Number of inversions are = {InversionCount(arr.Length)}");


        }
    }
}
