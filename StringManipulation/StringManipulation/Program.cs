using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string name = "Emirhan Aydin Cakil";
            string job = "Developer";

            Console.WriteLine("Hi I'm " + name + ", I am " + age + " years old.");
            Console.WriteLine("Hi I'm {0}, I am {1} years old.", name, age);
            Console.WriteLine($"Hi I'm  {name}, \n I'm {age} years old. I'm a {job}");
            Console.WriteLine(@"hahaha, \n dosen't work here");
            Console.Read();
        }
    }
}
