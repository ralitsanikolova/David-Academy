using System;

namespace _2.NameAndCourseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name, please: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter course name, please: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Здравейте " + studentName + " и добре дошли в " + courseName + "!");
        }
    }
}
