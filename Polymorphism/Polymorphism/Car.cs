using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {

            this.HP = hp;
            this.Color = color;

        }

        public void ShowDetails()
        {

            Console.WriteLine("Car's max speed is {0} and its color is {1}", HP, Color);
        }

        public virtual void Repair()
        {

            Console.WriteLine("Car was repaired!");
        }
    }
}
