
namespace BankLibrary
{
    public interface IBankingAccount
    {
         double GetBalance();
         bool WithDraw(double amount);
         bool Transfer(IBankingAccount toAccount, double amount);
         BankAccountTypeEnum AccountType { get; set; }
    }
}