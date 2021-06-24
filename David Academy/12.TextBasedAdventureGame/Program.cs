using System;

namespace _12.TextBasedAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escape the castle");
            Console.WriteLine();

            Console.WriteLine("Locked up in a tower, you find a secret way out by moving a bookshelf. \n" +
                " //of course it works every time duh \n " +
                "Time to escape!");

            Console.WriteLine("Speeding through the corridor there is a crossroad. Which one will you choose? " +
                "l or r");
            string movement = Console.ReadLine();
            bool again = false;

            switch (movement)
            {
                case "r":
                    Console.WriteLine("You found a staircase. Good job!");
                    break;
                case "l":
                    Console.WriteLine("Dead end.You have been caught.Say hello to Davy Jones");
                    break;
                default:
                    Console.WriteLine("Command is not valid, please try again:");
                    break;
            }
            Console.WriteLine("Second task: Down the staircase, there is a door with a weird locked.\n" +
                " The locket is a combination of 3 symbols, find them and you will unlock the door \n" +
            "You only get 3 chances! Use < , > , *");


            for (int i = 0; i <= 3; i++)
            {
                string symbols = Console.ReadLine();
                if (symbols == ">*<")
                {
                    Console.WriteLine("You have unlocked the door. Gongrtaz your are free!");
                }
                else
                {
                    Console.WriteLine("Wrong combination, sorry you are stuck here");

                }
            }
        }
    }
}
