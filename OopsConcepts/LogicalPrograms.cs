using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class LogicalPrograms
    {
        public void FlipCoin()
        {
            int headCount = 0;
            int tailCount = 0;
            
            Random random = new Random();
            Console.WriteLine("Enter Number of Times To Flip Coin");
            int flipCount = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < flipCount; i++)
            {
                repeatHead:
                double result = random.NextDouble();
                if(result < .5)
                {
                    headCount++;
                    goto repeatHead;
                }
                else
                {
                    tailCount++;
                }

            }
            Console.WriteLine("Head Count {0} total flip {1}",headCount,flipCount);
            Console.WriteLine("Tail Count {0} total flip {1}", tailCount, flipCount);
        }
    }
}
