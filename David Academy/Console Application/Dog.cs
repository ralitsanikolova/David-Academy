using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Dog : Animal
    {
        public void Bark(string breed, string color, int age, string eyeCOlor): base(breed, color, age, eyeColor)
        { 
        }
        void Bark() { 
            Console.WriteLine("Bau");
        }

        public override void SleepingSounds()
        {
            Console.WriteLine("Mrr");
        }

    }
}
