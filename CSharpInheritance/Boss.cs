using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from Employee

namespace CSharpInheritance
{
    internal class Boss: Employee
    {
        //Properties
        public string CompanyCar { get; set; }

        public Boss(string name, string firstName, int salary, string companyCar): base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working as a boss");
        }

        public void Lead()
        {
            Console.WriteLine($"{Name} is leading his employees");
        }
    }
}
