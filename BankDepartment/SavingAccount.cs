namespace BankDepartment
{
    public class SavingAcccount : IBankDetails
    {
        private decimal _balance;
        private decimal _perDayLimit;
        public double Deposit(double amount)
        {
            if(amount > 0)
            {
                _balance += amount;
                return true;
            }
        }
        public double WithDraw(double amount)
        {
            if(_balance < amount)
            {
                Console.WriteLine("Insufficent fund in your account");
                return false;
            }
            else if (_perDayLimit + amount > 2000)
            {
                Console.WriteLine("withdrawal attempt failed");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(string.Format($"Sucessfully withdraw, {0,6:C} {amount}"));
                return true;
            }
        }
        public decimal balance
        {
            get { return balance; }
        }
        public override string ToString()
        {
            return string.Format($"Saving Account balance = {0,6:C} {_balance}");
        }
    }
}