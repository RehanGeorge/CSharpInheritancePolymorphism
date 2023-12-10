using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface to be implemented by all destroyable objects

namespace CSharpInheritance
{
    internal interface IDestroyable
    {
        //Property to store the audio file of the destruction sound
        string DestructionSound { get; set; }

        //Method to destroy the object
        void Destroy();
    }
}
