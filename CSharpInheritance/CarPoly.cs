using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to AudiPoly & BMWPoly

namespace CSharpInheritance
{
    internal class CarPoly
    {
        public int HP { get; set; }
        public string Color { get; set; }

        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public CarPoly(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"This car has {HP} horsepower and is {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
