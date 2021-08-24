using Bank.Entities.Exception;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double limit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = limit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
