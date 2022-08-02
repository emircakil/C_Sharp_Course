using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance._2
{
    internal class Animal
    {

        public string name { get; set; }
        public int age { get; set; }
        public bool isHungry { get; set; }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.isHungry = true;
        }


        // virtual mathod can be overrided by classes that inherit from animal
        public virtual void makeSound() { }



        public virtual void eat() {

            if (isHungry)
            {

                Console.WriteLine($"{name} is eating.");

            }
            else {

                Console.WriteLine($"{name} isn't hungry.");
            }

        }
        public virtual void play() {

            Console.WriteLine($"{name} is playing.");
        }


    }
}
