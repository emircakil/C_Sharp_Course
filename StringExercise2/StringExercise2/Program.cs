using System;

namespace StringExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random string");
            string randomString = Console.ReadLine();

            Console.WriteLine("Enter character for search");
            char character = Console.ReadLine()[0];

            int searchIndex = randomString.IndexOf(character);

            Console.WriteLine("Character {0} index of {1}, on the string {2}", character, searchIndex, randomString );


            Console.WriteLine("Please enter your first name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine();

            string fullname = string.Concat(name, " ", surname);
            Console.WriteLine("Your name is {0}", fullname);

        }
    }
}
