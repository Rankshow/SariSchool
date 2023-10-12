
namespace BankLibrary;

class Program
{
    static void Main(string[] args)
    {
        BankAccount accA01 = new BankAccount(1000);
        accA01.AccountType = BankAccountTypeEnum.Current;
        BankAccount accA02 = new BankAccount(50000);
        accA02.AccountType = BankAccountTypeEnum.Saving;
        Console.WriteLine($"The current balance of the accA01 is: {accA01.GetBalance()}");
        Console.WriteLine($"The current balance of the accA02 is: {accA02.GetBalance()}");
        accA01.Deposit(1000);
        Console.WriteLine($"accA01.Deposit(1000) : { accA01.GetBalance() }");
        accA02.Deposit(3000);
        Console.WriteLine($"accA02.Deposit(3000): { accA02.GetBalance() }");
        accA01.Transfer(accA02, 1000);
        Console.WriteLine($"accA01.Transfer(accA02, 1000) is: {accA02.GetBalance()}");
        Console.WriteLine($"accA02.Transfer(accA02, 1000) is: {accA02.GetBalance()}");
    }
}
