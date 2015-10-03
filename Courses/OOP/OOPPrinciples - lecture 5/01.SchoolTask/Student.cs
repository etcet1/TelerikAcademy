namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Student : Person, IComment
    {
        public int ClassNumber { get; set; }

        public Student(string firstName, string secondName, string comment, int classNumber)
            : base(firstName, secondName, comment)
        {
            this.ClassNumber = classNumber;
        }
    }
}
