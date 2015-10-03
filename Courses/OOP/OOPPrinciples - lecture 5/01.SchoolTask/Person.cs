namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Comment { get; set; }

        protected Person(string firstName, string lastName, string comment)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Comment = comment;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
