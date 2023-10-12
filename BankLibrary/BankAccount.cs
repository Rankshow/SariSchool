namespace BankLibrary
{
    public class BankAccount : IBankAccount
    {
        protected double balance;
        public BankAccountTypeEnum? AccountType { get; set; }
        public BankAccountTypeEnum Account { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public BankAccount(double amount)
        {
            balance = amount;
        }
        public bool Deposit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine("The amount has been deposited");
                return true;
            }
            return false;
        }
        public bool WithDraw(double amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("The amount has been withrawed");
                return true;
            }
            return false;
        }
        public bool Transfer(IBankAccount toAccount, double amount)
        {
            return this.Deposit(amount) && this.WithDraw(amount);
        }
        public double GetBalance()
        {
            return balance;
        }
    }

    public interface IBankAccount
    {
    }

}