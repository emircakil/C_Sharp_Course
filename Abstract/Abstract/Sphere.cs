using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Sphere : Shape
    {
        public double r { get; set; } // radius

        public Sphere(double r) {

            Name = "Sphere";
            this.r = r;
        }


        public override void GetInfo()
        {

            Console.WriteLine($"This is a {Name}");
        }
        public override double Volume()
        {
            return Math.PI * (Math.Pow(r, 3)) * 4 / 3;
        }
    }
}
