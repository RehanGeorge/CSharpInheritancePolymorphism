using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Radio : ElectricalDevice
    {

        //Constructor for the Radio class
        public Radio(bool isOn, string brand): base(isOn, brand) { }

        //method to listen to the radio
        public void ListenToRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio");
            }
            else
            {
                Console.WriteLine("Radio is off");
            }
        }
    }
}
