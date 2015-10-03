namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Business : Customer
    {
        private int eik;

        public string Eik { get; private set; }
        public Business(string name, string eik)
            : base(name)
        {
            this.Eik = eik;
        }
    }
}