using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from CarPoly

namespace CSharpInheritance
{
    internal class BMWPoly : CarPoly
    {
        public string Model { get; set; }
        private string Brand { get; } = "BMW";

        public BMWPoly(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        //New keyword hides the base method when an instance of this class is used
        public new void ShowDetails()
        {
            Console.WriteLine($"This car {Brand} has {HP} horsepower and is {Color} and is a {Model}");
        }

        public sealed override void Repair()
        {
            Console.WriteLine($"BMW {Model} was repaired!");
        }
    }
}
