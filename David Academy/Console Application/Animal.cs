using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    abstract class Animal
    {
        public Animal(string breed, string color, int age, string eyeCOlor)
        {

        }

        public string breed { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public string eyeColor { get; set; }

        public abstract void SleepingSounds();
    }
}
