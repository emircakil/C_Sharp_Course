using System;

namespace StringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String myName;

            Console.WriteLine("Please enter yourname and surname");

            myName = Console.ReadLine();

            Console.WriteLine("Uppercase: {0}", myName.ToUpper());
            Console.WriteLine("Lovercase: {0}", myName.ToLower());
            Console.WriteLine("Trim: {0}", myName.Trim());
            Console.WriteLine("Substring 0 to 5: {0}", myName.Substring(0, 5));
        }
    }
}
