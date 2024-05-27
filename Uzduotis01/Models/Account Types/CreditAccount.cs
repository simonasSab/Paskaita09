namespace Uzduotis01
{
    internal class CreditAccount : Account, IPaymentMethod
    {
        public CreditAccount(string ownerName, double balance) : base(ownerName, balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}
