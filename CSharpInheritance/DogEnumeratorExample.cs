using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class DogEnumeratorExample
    {
        public string Name { get; set; }

        public bool IsNaughtyDog { get; set; }

        public DogEnumeratorExample(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine($"Dog: {Name} said Woof {numberOfTreats} times!.");
        }
    }
}
