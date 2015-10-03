namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student : Human
    {
        public int Grade { get; set; }

        public Student(int grade, string firstName, string secondName)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }

    }
}
