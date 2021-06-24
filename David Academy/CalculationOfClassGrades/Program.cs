using System;

namespace CalculationOfClassGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grades:");
            Console.WriteLine();

            int count;
            double sum=0;
            double grade=0;
            
            Console.WriteLine("Course: History.");
            Console.WriteLine("Please enter grades for students:");

            for (int i = 0; i <= 20; i++)
            {

                Console.WriteLine("Please enter count of grades:");
                count = int.Parse(Console.ReadLine());

                for (int j = 0; j < count; j++)
                {
                    Console.Write($"Student {i + 1}: ");
                    grade = double.Parse(Console.ReadLine());
                    
                    if (grade > 6.00)
                    {
                        Console.WriteLine("You have entered  invalid grade!");
                        break;
                    }
                }
                sum += grade;
                double avg = sum /count;
                Console.WriteLine($"Average score of student is {avg}.");
            }
            Console.WriteLine($"Average score of all students is {sum / 20}.");
        }
    }
}
