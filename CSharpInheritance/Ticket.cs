using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Ticket : IEquatable<Ticket>
    {
        //Property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }

        //Simple constructor for the Ticket class
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            if (other == null) return false;
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
