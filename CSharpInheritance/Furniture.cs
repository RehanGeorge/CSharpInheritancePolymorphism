using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to Chair

namespace CSharpInheritance
{
    internal class Furniture
    {
        //Properties
        public string Material { get; set; }
        public string Color { get; set; }

        //Constructors
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
