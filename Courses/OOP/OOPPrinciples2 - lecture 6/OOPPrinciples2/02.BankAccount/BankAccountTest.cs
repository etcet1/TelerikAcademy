namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BankAccountTest
    {
        static void Main()
        {
            Individual pesho = new Individual(18, "Pesho", "male");

            Loan peshoLoan = new Loan(pesho, 1000, 4, 12);

            peshoLoan.DepositMoney(100);

            Console.WriteLine("The client " + pesho.Name + " owns " + peshoLoan.AccountBalance + " EUR");
        }
    }
}
