using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable
{
    internal class Program
    {

       

        static void Main(string[] args)
        {

            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter) {

                if (!dog.isNaughty)

                dog.woof(2);
            
                else 
                    dog.woof(10);

            }

        }

        class Dog {

            public string Name { get; set; }
            public bool isNaughty { get; set; }

            public Dog(string name, bool isNaughty) {

                this.Name = name;
                this.isNaughty = isNaughty;


            }

            public void woof(int woofCount) {

                Console.WriteLine("{0} is woofing {1} times.", Name, woofCount);


            }

        }
        class DogShelter : IEnumerable<Dog> {

            List<Dog> dogs;

            public DogShelter() {

                dogs = new List<Dog> {

            new Dog("Waffle", false),
                new Dog("Bidik", true),
              new Dog("Kader", false),
            };
        }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return dogs.GetEnumerator();

            }

            IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

    }
}
