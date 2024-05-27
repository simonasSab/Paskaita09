namespace Uzduotis01
{
    internal interface IPaymentMethod
    {
        void Pay(double amount);
        bool CheckBalance(double amount);
    }
}
