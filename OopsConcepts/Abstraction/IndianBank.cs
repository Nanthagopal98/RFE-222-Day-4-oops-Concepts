using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    internal class IndianBank : Bank
    {
        public override void LoanIntrerest()
        {
            Console.WriteLine("Loan Interest : .65 paise");
        }
    }
}
