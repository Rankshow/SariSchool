namespace BankDepartment;

class Program
{
    static void Main(string[] args)
    {
        IBankDetails SavingAcccount = new SavingAcccount();
        IBankAccount currentAccount = new CurrentAcccount();
        savingAcccount.Deposit(500);
        savingAcccount.WithDraw(600);
        savingAcccount.ToString();

        currentAccount.Deposit(30000);
        currentAccount.withdraw(3000);
        currentAccount.ToString();
 
    }
}
