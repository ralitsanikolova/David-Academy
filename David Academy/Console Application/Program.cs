using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat whiteCat = new Cat("Stray", "white", 4 , "purple" );
            Dog whiteDog = new Dog("Stray", "white", 10, "brown");



            whiteCat.SleepingSounds();
            whiteDog.SleepingSounds();
        }
    }
}
