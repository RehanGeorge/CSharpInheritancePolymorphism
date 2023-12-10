using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to DogEnumeratorExample

namespace CSharpInheritance
{
    internal class DogShelter : IEnumerable<DogEnumeratorExample>
    {
        public List<DogEnumeratorExample> dogs;

        public DogShelter()
        {
            dogs = new List<DogEnumeratorExample>()
            {
                new DogEnumeratorExample("Fido", false),
                new DogEnumeratorExample("Rex", false),
                new DogEnumeratorExample("Spike", true),
                new DogEnumeratorExample("Buddy", false),
                new DogEnumeratorExample("Max", false),
            };
        }

        IEnumerator<DogEnumeratorExample> IEnumerable<DogEnumeratorExample>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
