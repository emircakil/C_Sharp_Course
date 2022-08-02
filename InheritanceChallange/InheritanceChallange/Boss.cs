using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallange
{
    internal class Boss : Employee
    {
        

        public string CompanyCar { get; set; }

        public Boss(string name, string firstName, int salary, string CompanyCar) : base(name, firstName, salary)
        {
            this.CompanyCar = CompanyCar;

        }

        public void Lead() {

            Console.WriteLine("Boss lead at the a property {0}", CompanyCar);
        }

    }
}
