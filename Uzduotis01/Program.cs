namespace Uzduotis01
{
    internal class Program
    {
        static List<Account> accounts = new();

        public static void Main(string[] args)
        {
            // Add 20 random accounts
            for (int i = 0; i < 20; i++)
            {
                accounts.Add(NewRandomAccount());
            }
            Console.WriteLine();

            // Try to buy something for 50 Eur
            MakePurchace(50);

            // Try to buy something for 500 Eur
            MakePurchace(500);

            // Try to buy something for 1000 Eur
            MakePurchace(1000);


            // Try to buy something for 5000 Eur
            MakePurchace(5000);
        }

        public static Account NewRandomAccount()
        {
            // Make name
            Random random = new();
            int nameTag = random.Next(0,1000);
            string name = $"John{nameTag:000}";

            // Make random balance

            double balance = Math.Round((random.NextDouble() * 100 + random.NextDouble() * 10000), 2);

            // Create account and return it
            if (random.NextDouble() >= 0.5)
            {
                CreditAccount account = new(name, balance);
                Console.WriteLine($"Created Credit Account {account.ToString()}");
                return account;
            }
            else
            {
                DebitAccount account = new(name, balance);
                Console.WriteLine($"Created Debit  Account {account.ToString()}");
                return account;
            }
        }

        public static void MakePurchace(double amount)
        {
            Console.WriteLine($"Buying for {amount} Eur:\n");
            foreach (Account account in accounts)
            {
                if (account.CheckBalance(amount))
                {
                    account.Pay(amount);
                    Console.WriteLine($"Payment successful! Remaining balance: {account.GetBalance():.00}");
                }
                else
                {
                    account.Pay(amount);
                }
            }
            Console.WriteLine();
        }
    }
}