using System;
using System.Collections.Generic;
using System.Text;

namespace _21._GoldDiggers
{
    class FieldBounds
    {
        public void GetFieldBounds()
        {
            int startX = 10;
            int startY = 10;

            Console.WriteLine("Please enter numbers: \n Number №1:");
            int maxX = int.Parse(Console.ReadLine());
            Console.WriteLine("Number №2:");
            int maxY = int.Parse(Console.ReadLine());

            if (maxX == int.Parse(Console.ReadLine()))
            {
                Console.WriteLine($"Your field bounds are from {startX} to {maxX}");
            }
            else
            {
                Console.WriteLine("You haven't choosed a bound.");

            }


            if (maxY == int.Parse(Console.ReadLine()))
            {
                Console.WriteLine($"Your field bounds are from {startY} to {maxY}");
            }
            else
            {
                Console.WriteLine("You haven't choosed a bound.");
            }
        }

        private double ground = 0.4;
        private double grass = 0.3;
        private double tree = 0.2;
        private double stone = 0.1;
    }
}

