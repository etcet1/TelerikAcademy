namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Deposit : Account, IDraw, IDeposit
    {
        private int depositPeriod;

        public int DepositPeriod { get; set; }

        public Deposit(Customer accountHolder, decimal accoutBalance, decimal interestRate, int depositPeriod)
            : base(accountHolder, accoutBalance, interestRate)
        {
            this.DepositPeriod = depositPeriod;
        }

        public override decimal DepositMoney(decimal money)
        {
            this.AccountBalance += money;
            return this.AccountBalance;
        }

        public override decimal DrawMoney(decimal money)
        {
            if (this.AccountBalance >= money)
            {
                this.AccountBalance -= money;
                return this.AccountBalance;
            }
            else
            {
                throw new ArgumentException("You don't have enough money!");
            }
        }

        public override decimal CalculateInterest()
        {
            if (this.AccountBalance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.depositPeriod * this.InterestRate;
            }
        }
    }
}