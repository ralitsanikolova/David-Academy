using System;

namespace _17.TemperaturesDuringWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Random rand = new Random((int)now.Millisecond);

            int[,] weather = new int[7, 6];
            for (int x = 0; x < weather.GetLength(0); x++)
            {
                for (int y = 0; y < weather.GetLength(1); y++)
                {
                    weather[x, y] = 10 + rand.Next() % 20;
                }
            }

            Console.WriteLine("Temperatures during week: ");
            Console.WriteLine();

            Console.WriteLine("Time    00  04  08  12  16  20 ");
            Console.WriteLine("        -----------------------");

            int[] average = new int[7];

            for (int x = 0; x < weather.GetLength(0); x++)
            {
                Console.Write($"Day{x + 1}: ");
                for (int y = 0; y < weather.GetLength(1); y++)
                {
                    average[y] += weather[x, y];
                    Console.Write("{0,4:D}", weather[x, y]);
                }
                Console.WriteLine();
            }

            Console.Write("\r \n Avg");
            foreach (int Avg in average)
            {
                Console.Write("{0,4:D}", Avg / weather.GetLength(0));
            }
            Console.WriteLine();

        }
    }
}
    


