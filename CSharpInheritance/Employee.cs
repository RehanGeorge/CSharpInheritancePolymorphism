using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Employee
    {
        //Properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //Constructor
        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        //Method
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"{Name} is pausing work");
        }

        public override string ToString()
        {
            return $"{Name} with {Salary}";
        }
    }
}
