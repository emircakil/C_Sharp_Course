using System;

namespace Inhertiance._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog waffle = new Dog("Waffle", 4);

            Console.WriteLine("{0} is {1} years old.", waffle.name, waffle.age);

            waffle.play();
            waffle.eat();
            waffle.makeSound();

        }
    }
}
