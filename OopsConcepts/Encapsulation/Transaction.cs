using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Encapsulation
{
    public class Transaction
    {
        private int Balance;
        private int AccountNumber;

        public int GetBalance()
        {
            Console.WriteLine("Available Balance:"+Balance);
            return Balance;
        }
        public void SetBalance(int value)
        {
            this.Balance = value;
        }

        public int Amount
        {
            get 
            {
                return this.AccountNumber;
            }
            set
            {
                if (value > 0)
                {
                    this.AccountNumber = value;
                    Console.WriteLine("Account Number:" + this.AccountNumber);
                }
                else
                    Console.WriteLine("Enter Valid Account Number");
            }
        }
        public int PanNumber { get; set; }

    }
}
