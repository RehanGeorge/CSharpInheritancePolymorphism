using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from CarPoly

namespace CSharpInheritance
{
    internal class AudiPoly : CarPoly
    {
        public string Model { get; set; }
        private string Brand { get; } = "Audi";

        public AudiPoly(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"This car has {HP} horsepower and is {Color} and is a {Model}");
        }

        public override void Repair()
        {
            Console.WriteLine("Audi was repaired!");
        }
    }
}
