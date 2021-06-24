using System;

namespace _16.SumElementsOfQuadraticMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of the columns:");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Enter cells of the matrix:");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.WriteLine($"Matrix [ {row} {column} ]");
                    matrix[row, column] = (int)double.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.WriteLine("" + matrix[row, column]);
                }
                Console.WriteLine();
            }

            int sumDiag = 0;
            Console.WriteLine("Sum of digonal:");
            for(int row = 0; row < rows; row++)
            {
                sumDiag = sumDiag + matrix[row, row];
                
            }
            Console.WriteLine($"Sum = {sumDiag}");


            int sumDown = 0;
            for (int row = 0; row < rows; row++)
            {
                for(int column = 0; column <= row; column++)
                {
                    sumDown = sumDown + matrix[row, column];
                }
            }
            Console.WriteLine($"Sum = {sumDown}");


            int sumUp = 0;
            for (int row = 0; row > rows; row++)
            {
                for (int column = 0; column >= row; column++)
                {
                    sumUp = sumUp + matrix[row, column];
                }
            }
            Console.WriteLine($"Sum = {sumUp}");
        }
    }
}
