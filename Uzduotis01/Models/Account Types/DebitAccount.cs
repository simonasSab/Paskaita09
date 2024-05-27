namespace Uzduotis01
{
    internal class DebitAccount : Account, IPaymentMethod
    {
        public DebitAccount(string ownerName, double balance) : base(ownerName, balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}
