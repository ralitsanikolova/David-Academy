using System;

namespace _28.SoftwareAcademy
{
    class Academy
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Course email = new Course();

            Console.WriteLine("Software Academy");
            Console.WriteLine();

            Console.Write("Student: Name = ");
            student.setName(Console.ReadLine());

            Console.Write(", FN = ");
            student.setfNumber(Console.ReadLine());

            Console.WriteLine("Email: ");
            email.setEmail(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Course course = new Course();


                Console.WriteLine("Course :");
                course.setCourseName(Console.ReadLine());

                student.addCourse(course, i);
            }

            Console.WriteLine();

            Console.WriteLine($"Student: Name = {student.getName()} , FN = {student.getfNumber()}, Email = {email.getEmail()}");

            for (int i = 0; i < student.getCoursesCount(); i++)
            {
                Console.WriteLine($"Course {i + 1}: {student.GetCourseName(i)}");
            }
        }
    }
}
