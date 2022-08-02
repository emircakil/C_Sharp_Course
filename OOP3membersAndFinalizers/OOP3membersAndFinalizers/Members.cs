using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3membersAndFinalizers
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        public string JobTitle
        {

            get
            { 
              return jobTitle;
            }
            set
            {
                this.jobTitle = value;

            }
        }

        public void Introduce(bool isFriend) {

            if (isFriend)
            {
                SharingPrivateInfos();
            }
            else {

                Console.WriteLine("Hi I'm {0} and {1} years old. My job is {2}.", memberName, age, jobTitle);
            }
        
        
        }

        private void SharingPrivateInfos() {

            Console.WriteLine("My salary is {0}", salary);

        }

        public Members() {

            age = 30;
            salary = 20000;
            memberName = "kratos";
            jobTitle = "Developer"; 

            Console.WriteLine("Object Created.");
        }

        ~Members () {

            // cleanup members
            
            Console.WriteLine("Deconcruction of Member Object");
            Debug.Write("Deconcruction of Member Object");

        }
    }

}
