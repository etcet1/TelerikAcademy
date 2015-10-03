namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Loan : Account, IDeposit
    {

        private int loanPeriod;

        public int LoanPeriod { get; set; }

        public Loan(Customer accountHolder, decimal accoutBalance, decimal interestRate, int loanPeriod)
            : base(accountHolder, accoutBalance, interestRate)
        {
            this.LoanPeriod = loanPeriod;
        }

        public override decimal DepositMoney(decimal money)
        {
            this.AccountBalance -= money;
            return this.AccountBalance;
        }
    }
}
