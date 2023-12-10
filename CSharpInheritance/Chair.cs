using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to Furniture

namespace CSharpInheritance
{
    internal class Chair : Furniture, IDestroyable
    {
        //implementing the interface property
        public string DestructionSound { get; set; }

        public Chair(string color, string material): base(color, material)
        {
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }
    }
}
