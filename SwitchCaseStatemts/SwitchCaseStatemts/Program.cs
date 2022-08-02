using System;

namespace SwitchCaseStatemts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            switch (age) {

                case 15:
                    Console.WriteLine("It's too young for party");
                    break;
                case 18:
                    Console.WriteLine("Good for party");
                    break;
                case 25:
                    Console.WriteLine("Good for party");
                    break;
                default:
                    Console.WriteLine("How old are you?");
                    break;
            }

            Console.Read();

        }
    }
}
