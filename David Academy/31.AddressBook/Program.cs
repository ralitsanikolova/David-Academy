using System;

namespace _31.AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book:");
            Console.WriteLine("-------------");

            int size;
            Console.WriteLine("How many contacts do you have?");
            size = int.Parse(Console.ReadLine());

            string[] names = new string[size];
            string[] phones = new string[size];
            string[] adrress = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter contact {i + 1}");
                names[i] = Console.ReadLine();
                Console.WriteLine("Phone:");
                phones[i] = Console.ReadLine();
                Console.WriteLine("Address: ");
                adrress[i] = Console.ReadLine();
            }
            Console.Write("Search by name:");
            string searchQuery = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (names[i].Equals(searchQuery))
                {
                    Console.WriteLine("Found: %s%n", phones[i]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found");
            }
        }
    }
}