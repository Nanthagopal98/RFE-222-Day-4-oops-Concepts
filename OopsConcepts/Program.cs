// See https://aka.ms/new-console-template for more information
using OopsConcepts.Abstraction;
using OopsConcepts.Inheritance;
using OopsConcepts.Polymorphism;

Console.WriteLine("1:Inheritance\n2:Abstraction\n3:Polymorphism-Overloading\n4:Polymorphism-Overriding");
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
        //child = new OverRiding();

        break;
}

