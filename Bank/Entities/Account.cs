using Bank.Entities.Excepitions;
using System.Globalization;


namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount; 
        }
        public void Withdraw(double amount)
        {
            if(Balance == 0.0)
            {
                throw new DomaineExceptions("You don't have money in your account"); 
            }
            if(amount > WithdrawLimit)
            {
                throw new DomaineExceptions("The amount exceeds withdraw limit"); 
            }
            if (amount > Balance)
            {
                throw new DomaineExceptions("Not enough balance "); 
            }
            
            Balance -= amount; 
        }

    }
}
