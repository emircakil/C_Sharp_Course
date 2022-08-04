using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polymorphism.Program;

namespace Polymorphism
{
    internal class BMW : Car
    {
        private string brand { get; set; }
        public string Model { get; set; }
        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
            this.brand = "BMW";

        }

        public new void ShowDetails() {

            Console.WriteLine("BMW {0}, Color {1}, HP {2}", Model, Color, HP);
        }

        public override void Repair() {

            Console.WriteLine("BMW {0} is repaired", Model);
        }

    }
}
