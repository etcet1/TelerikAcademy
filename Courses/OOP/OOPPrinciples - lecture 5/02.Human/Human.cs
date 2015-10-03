namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Human
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

    }
}
