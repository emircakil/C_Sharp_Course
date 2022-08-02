using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio: ElectricalDevices
    {

        // child class

        public Radio(bool isOn, string brand):base(isOn,brand)
        {
        }

        public void ListenRadio() {

            if (IsOn)
                Console.WriteLine("Radio is open");
            else
                Console.WriteLine("Radio is close");

        }


    }
}
