using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance._2
{
    internal class Dog : Animal
    {

        public bool isHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            isHappy = true;

        }

        public override void eat()
        {
            base.eat();
        }

        public override void makeSound()
        {
            // we dont use base beacuse make sound method differnet for the each animal.

            Console.WriteLine("Wooof!");

        }
        public override void play()
        {

            if(isHappy)
            base.play();
        }


    }
}
