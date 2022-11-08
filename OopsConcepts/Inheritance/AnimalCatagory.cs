using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Inheritance
{
    internal class AnimalCatagory : Animal
    {
        public void Swimming()
        {
            Console.WriteLine("Sea Species Can Swim");
        }
        public void Flying()
        {
            Console.WriteLine("Birds can Fly");
        }
        public void Run()
        {
            Console.WriteLine("Tiger Can Run");
        }
    }
}
