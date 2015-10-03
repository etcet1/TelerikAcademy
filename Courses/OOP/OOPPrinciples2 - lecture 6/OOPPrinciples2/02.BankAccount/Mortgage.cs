namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mortgage : Account, IDeposit
    {
        private int mortgagePeriod;

        public int MortgagePeriod { get; set; }

        public Mortgage(Customer accountHolder, decimal accoutBalance, decimal interestRate, int mortgagePeriod)
                : base(accountHolder, accoutBalance, interestRate)
        {
            this.MortgagePeriod = mortgagePeriod;
        }

        public override decimal DepositMoney(decimal money)
        {
            this.AccountBalance -= money;
            return this.AccountBalance;
        }

        public override decimal CalculateInterest()
        {
 	        if (this.mortgagePeriod<=12 && this.AccountHolder is Business)
	        {
                return this.InterestRate / 2 * this.mortgagePeriod;
	        }
            else if(this.mortgagePeriod<=12 && this.AccountHolder is Individual)
	        {
                return 0;
	        }
            else
            {
                return this.InterestRate * this.mortgagePeriod;
            }
        }
    }
}
