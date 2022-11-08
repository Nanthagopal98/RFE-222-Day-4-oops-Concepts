using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    internal abstract class Bank
    {
        public abstract void LoanIntrerest();
        public void BankConfidentials()
        {
            Console.WriteLine("All Banks have Some Confidential Informations");
        }
    }
}
