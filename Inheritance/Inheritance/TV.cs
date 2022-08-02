using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV: ElectricalDevices
    {

        public TV (bool isOn, string brand):base(isOn, brand)
        {
        }

        public void ListenTV() {

            if (IsOn)
                Console.WriteLine("TV is open");
            else
                Console.WriteLine("Tv is close");
        }

    }
}
