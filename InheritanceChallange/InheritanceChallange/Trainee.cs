using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallange
{
    internal class Trainee : Employee
    {
       

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salary, int WorkingHours, int SchoolHours) : base(name, firstName, salary)
        {

            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;

        }

        public void Learn() {

            Console.WriteLine("Trainee learning {0} hours.", SchoolHours);
        }

        public override void Work() {

            Console.WriteLine("Trainee working {0} hours.", WorkingHours);
            
        }

    }
}
