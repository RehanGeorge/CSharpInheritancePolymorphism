using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Vehicle
    {
        //Properties
        public float Speed { get; set; }
        public string Color { get; set; }

        //Constructors
        public Vehicle()
        {
            Speed = 0;
            Color = "White";
        }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
