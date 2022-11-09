using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism
{
    internal class Child : OverRiding   //chlid class
    {
        public override void Sample()
        {
            base.Sample();  //we can ass base class function with some additional logics in child class
            Console.WriteLine("From Child");
        }
    }
}
