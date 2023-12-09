using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age, bool isHungry) : base(name, age, isHungry) 
        {
            IsHappy = true;
        }

        //Simple override of the MakeSound method
        public override void Eat()
        {
            //Call the base method
            base.Eat();
        }

        //Simple override of the MakeSound method
        public override void MakeSound()
        {
            //Each animal makes a different sound
            Console.WriteLine("Woof!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
