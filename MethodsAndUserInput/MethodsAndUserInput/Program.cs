using System;

namespace MethodsAndUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add());
        }

        public static int Add() {

            Console.WriteLine("Please enter a number");        
            string number1String = Console.ReadLine();
            Console.WriteLine("Please enter a second number");
            string number2String = Console.ReadLine();

            int num1 = int.Parse(number1String);
            int num2 = int.Parse(number2String);

            int result = num1 + num2;

            return result;
        }
    }
}
