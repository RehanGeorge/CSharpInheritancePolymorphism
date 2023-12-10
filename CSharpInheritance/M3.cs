using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from BMWPoly which inherits from CarPoly

namespace CSharpInheritance
{
    internal class M3:BMWPoly
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
        }

        //Sealed in the base class, so this will not compile
        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
