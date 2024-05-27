namespace Uzduotis01
{
    internal class Account
    {
        public string OwnerName { get; set; }
        protected double Balance { get; set; }

        public Account(string ownerName, double balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double newBalance)
        {
            Balance = newBalance;
        }

        public override string ToString()
        {
            return $"{OwnerName} {Balance}:.00";
        }

        public bool CheckBalance(double amount)
        {
            if (GetBalance() >= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Pay(double amount)
        {
            if (Balance >= amount)
            {
                SetBalance(GetBalance() - amount);
            }
            else
            {
                Console.WriteLine($"Insufficient funds - payment unsuccessful.");
            }
        }
    }
}
