using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
   

    class Cat : Animal
    {
        public Cat(string breed, string color, int age, string eyeColor) : base(breed, color, age, eyeColor)
        {

        }
        public override void SleepingSounds()
        {
            throw new NotImplementedException();
        }
    }
}
