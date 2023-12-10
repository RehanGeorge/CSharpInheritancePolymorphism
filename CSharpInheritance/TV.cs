using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from ElectricalDevice

namespace CSharpInheritance
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        //method to listen to the radio
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching the TV");
            }
            else
            {
                Console.WriteLine("TV is off");
            }
        }
    }
}
