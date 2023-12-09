using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    internal class Trainees: Employee
    {
        //Properties
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        //Constructor
        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours): base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        //Method
        public void Learn()
        {
            Console.WriteLine($"{Name} is learning");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working and has {WorkingHours} working hours."); ;
        }
    }
}
