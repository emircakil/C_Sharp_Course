using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =  { new Cube(3), new Sphere(4) };

            foreach (Shape shape in shapes) {

                shape.GetInfo();

                Console.WriteLine("{0} is volume of {1}", shape.Volume(), shape.Name);

                Cube iceCube = shape as Cube;



                if (iceCube == null) {

                    Console.WriteLine("That isn't a cube");
                }

                if (shape is Cube) {

                    Console.WriteLine($"Hi im cube and my name is {shape.Name}");
                }

            }


        }
    }
}
