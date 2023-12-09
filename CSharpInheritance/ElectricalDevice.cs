using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class ElectricalDevice
    {

        //boolean to determine the state of the ElectricalDevice
        public bool IsOn { get; set; }

        //string for the brand of the ElectricalDevice
        public string Brand { get; set; }

        //Constructor for the ElectricalDevice class
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //Method to turn the ElectricalDevice on
        public void SwitchOn()
        {
            IsOn = true;
        }

        //Method to turn the ElectricalDevice off
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
