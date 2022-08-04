using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polymorphism.Program;

namespace Polymorphism
{
    internal class Audi : Car
    {
        private string brand { get; set; }
        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {

            this.Model = model;
            this.brand = "Audi";
        }

        public void ShowDetails()
        {

            Console.WriteLine("Audi {0}, Color {1}, HP {2}", Model, Color, HP);
        }

        public void Repair()
        {

            Console.WriteLine("Audi {0} is repaired", Model);
        }

    }
}
