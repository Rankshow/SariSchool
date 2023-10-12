namespace BankDepartment
{
    public class CurrentAcccount : IBankDetails
    {
        private  decimal _balance;
        private  decimal _perDayLimit;
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
                Console.WriteLine("Insufficent balance");
                return false;
            }
            else
            {
                _balance -= amount;
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
            return string.Format($"Current Account balance = {0,6:C} {_balance}");
        }
    }
}