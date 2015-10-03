namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Account : IDeposit, IDraw
    {
        private Customer accountHolder;
        private decimal accountBalance;
        private decimal interestRate;

        private int NumberOfMonts { get; set; }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
        }

        public Customer AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        protected Account(Customer accountHolder, decimal accountBalance, decimal interestRate)
        {
            this.AccountHolder = accountHolder;
            this.accountBalance = accountBalance;
            this.interestRate = interestRate;
        }

        public virtual decimal DepositMoney(decimal money)
        {
            return this.AccountBalance;
        }
        public virtual decimal DrawMoney(decimal money)
        {
            return this.AccountBalance;
        }
        public virtual decimal CalculateInterest()
        {
            return NumberOfMonts * this.InterestRate;
        }
    }
}
