using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism
{
    internal class OverLoading
    {
        public void Addition(int a, int b)
        {
            int x = a + b;
            Console.WriteLine("Addition Two Number:" + x);
        }

        public void Addition(int a, int b, int c)
        {
            int x = a + b + c;
            Console.WriteLine("Addition of Three Number:"+x);
        }
        public void Addition(int a, float d)
        {
            float x = a + d;
            Console.WriteLine("Addition of int And float:" + x);
        }
    }
}
