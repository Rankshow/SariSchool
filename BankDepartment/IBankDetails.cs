namespace BankDepartment
{
    public interface IBankDetails
    {
         double Deposit(double amount);
         double WithDraw(double amount);
         float balance { get; }
    }
}