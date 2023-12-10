using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to Vehicle and IDestroyable

namespace CSharpInheritance
{
    internal class Car : Vehicle, IDestroyable
    {
        //Implement the IDestroyable interface
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        //Simple constructor
        public Car(float speed, string color) : base(speed, color) 
        {
            DestructionSound = "Crash!";
            DestroyablesNearby = new List<IDestroyable>();
        }

        //Method to destroy the object
        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine($"Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
