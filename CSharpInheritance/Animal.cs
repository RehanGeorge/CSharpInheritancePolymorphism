using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Animal linked to Dog

namespace CSharpInheritance
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age, bool isHungry)
        {
            Name = name;
            Age = age;
            IsHungry = isHungry;
        }

        //Method to make sound
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making a sound");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
