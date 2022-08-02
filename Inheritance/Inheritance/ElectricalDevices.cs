using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ElectricalDevices 
    {

        // parent class

        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevices(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn() {

            IsOn = true;
        }

        public void SwitchOff() {

            IsOn = false;
        }





    }
}
