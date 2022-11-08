// See https://aka.ms/new-console-template for more information
using OopsConcepts.Abstraction;
using OopsConcepts.Inheritance;

Console.WriteLine("1:Inheritance\n2:Abstraction");
int option = Convert.ToInt32(Console.ReadLine());
switch (option) 
{
    case 1:
        Tiger tiger = new Tiger();
        tiger.size();
        tiger.Sound();
        tiger.Run();
        break;

    case 2:
        IndianBank bank = new IndianBank();
        bank.LoanIntrerest();
        bank.BankConfidentials();
        break;
}

