using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube (double length)
        {   
            Name = "Cube";
            Length = length;
        }

        public override void GetInfo()
        {

            Console.WriteLine($"This is a {Name}");
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);

        }
    }
}
