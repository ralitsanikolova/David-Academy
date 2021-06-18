using System;

namespace _1.DiscriminantOfSquare_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Discriminant of square root:");
            Console.WriteLine();

            Console.WriteLine("Please enter a:");
            double aDiscr = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a:");
            double bDiscr = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c:");
            double cDiscr = double.Parse(Console.ReadLine());

            double discr = (Math.Sqrt(bDiscr) - 4 * aDiscr * cDiscr);
            Console.WriteLine("The discriminant is :" + discr);

        }
    }
}
