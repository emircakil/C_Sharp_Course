using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLinee();
            WriteStringg("This is writing comes as parameter from main method");

            Console.WriteLine(Sum(Sum(9, 23), Sum(11, 10)));


            Console.Read();
        }

        public static void WriteLinee() {

            Console.WriteLine("This is writing on a method");
        
        }

        public static void WriteStringg(string myString) {

            Console.WriteLine(myString);
        
        }

        public static int Sum(int number1, int number2) {

            return number1 + number2;
        
        }

    }
}
