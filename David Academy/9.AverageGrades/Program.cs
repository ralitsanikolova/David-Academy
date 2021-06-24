using System;

namespace _9.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average grades in class:");
            Console.WriteLine();

            Console.Write("Please type count of students:");
            int students = int.Parse(Console.ReadLine());
            Console.WriteLine("For every student  will be typed grade");

            Console.WriteLine("Please enter grades");

            double sumGrade = 0;
            for (int i = 1; i <= students; i++)
            {
                Console.Write($"Number-{i} : ");
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 2.99)
                {
                    Console.WriteLine("Fail");
                }

                else if (grade == 3 && grade <= 3.49)
                {
                    Console.WriteLine("Sreden ");
                }
                else if (grade >= 3.50 && grade <= 4.49)
                {
                    Console.WriteLine("Good");
                }
                else if (grade >= 4.50 && grade <= 5.49)
                {
                    Console.WriteLine("Very Good");
                }
                else if (grade >= 5.50 && grade <= 6.00)
                {
                    Console.WriteLine("Excelent");
                }
                else
                {
                    Console.WriteLine("Please enter valid grade!");
                    return;
                }

                for (int j = 0; j < students; j++)
                {
                    sumGrade += grade;
                }
            }
            

            Console.WriteLine($"Average of all students is {sumGrade / students}");
        }

    }

}


