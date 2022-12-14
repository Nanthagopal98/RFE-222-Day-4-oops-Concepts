// See https://aka.ms/new-console-template for more information
using OopsConcepts;
using OopsConcepts.Abstraction;
using OopsConcepts.Encapsulation;
using OopsConcepts.Inheritance;
using OopsConcepts.Polymorphism;

Console.WriteLine("1:Inheritance\n2:Abstraction\n3:Polymorphism-Overloading\n4:Polymorphism-Overriding\n5:Encapsulation" +
    "\n6:Flip Coin");
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
    case 3:
        
        Console.WriteLine("Enter Value for a :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value for b :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value for c :");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Float Value for d :");
        float d = (float)Convert.ToDouble(Console.ReadLine());
        OverLoading overLoading = new OverLoading();
        overLoading.Addition(a, b);
        overLoading.Addition(a,b,c);
        overLoading.Addition(a,d);
        break;
    case 4:
        Child child = new Child();
        child.Sample();
        break;
    case 5:
        Console.WriteLine("Enter Balance");
        int abalance = Convert.ToInt32(Console.ReadLine());
        Transaction transaction = new Transaction();
        transaction.SetBalance(abalance);
        transaction.GetBalance();
        Console.WriteLine("Enter Accouunt Number");
        int Acc = Convert.ToInt32(Console.ReadLine());
        transaction.Amount = Acc;
        transaction.PanNumber = 12345;
        break;
    case 6:
        LogicalPrograms logicalPrograms = new LogicalPrograms();
        logicalPrograms.FlipCoin();
        break;
}

