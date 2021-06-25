using System;
using System.Collections.Generic;
using System.Text;

namespace _28.SoftwareAcademy
{
    class Course
    {
        private string courseName;
        private string email;

        public string getCourseName()
        {
            return courseName;
        }

        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}
