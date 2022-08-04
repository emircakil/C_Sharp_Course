using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {

                new BMW(250,"blue","MX5"),
                new Audi(200, "Red", "M3")

            };

            foreach (var car in cars) {

                car.Repair();
            }
            Console.WriteLine();

            BMW bmw1 = new BMW(330, "Black", "1");
            Car bmw2 = new BMW(400, "Red", "2");

            bmw1.ShowDetails();
            bmw1.Repair();
            Console.WriteLine();

            bmw2.ShowDetails();
            bmw2.Repair();

            Console.WriteLine();

            Car bmw11 = (Car)bmw1;
            bmw11.ShowDetails();
            bmw11.Repair();
            
        }

 

        

    }
}
