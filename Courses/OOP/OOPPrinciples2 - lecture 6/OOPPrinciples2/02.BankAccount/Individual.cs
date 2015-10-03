namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Individual : Customer
    {
        private int age;
        private string sex;

        public int Age { get; private set; }
        public string Sex { get; private set; }

        public Individual(int age, string name, string sex)
            : base(name)
        {
            this.Age = age;
            this.Sex = sex;
        }
    }
}