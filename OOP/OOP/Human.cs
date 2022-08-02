using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        private string name;
        private string lastName;
        private string eyeColor;
        private int age;
        private int values;

        public Human(string name, string lastName, string eyeColor, int age) {

            this.name = name;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

            values = 0;
        }

        public Human(string name, string lastName, string eyeColor) {

            this.name = name;
            this.lastName = lastName;
            this.eyeColor = eyeColor;

            values = 1;
        
        }

        public Human(string name, string lastName) {

            this.name = name;
            this.lastName = lastName;

            values = 2;
        }

        public Human() {

            name = "Bilgin";
            lastName = "Ozcalkan";
            eyeColor = "brown";
            age = 45;
            values = 0;
        }


        public void IntroduceMyself (){

            if (values == 0)

            Console.WriteLine("Hi I'm {0} {1}. My eyecolor is {2} and I'm {3} years old.", name , lastName, eyeColor, age);
        
            else if (values == 1)
            Console.WriteLine("Hi I'm {0} {1}. My eyecolor is {2}.", name, lastName, eyeColor);
            else if (values == 2)
            Console.WriteLine("Hi I'm {0} {1}.", name, lastName);

        }



    }
}
