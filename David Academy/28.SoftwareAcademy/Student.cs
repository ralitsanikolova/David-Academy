using System;

namespace _28.SoftwareAcademy
{
    class Student
    {
        private string name;
        private string fNumber;
        private Course[] courseName;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getfNumber()
        {
            return fNumber;
        }

        public void setfNumber(string fNumber)
        {
            this.fNumber = fNumber;
        }
        public Student()
        {
            courseName = new Course[5];
        }

        public void addCourse(Course courseNames, int index)
        {
            courseName[index] = courseNames;
        }

        public Course GetCourseName(int index)
        {
            return courseName[index];
        }

        public int getCoursesCount()
        {
            return courseName.Length;
        }
    }
}
