using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Sphere : Shape
    {

        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return Math.Pow(Radius, 3) * Math.PI * (4 / 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a radius of {Radius}");
        }
    }
}
