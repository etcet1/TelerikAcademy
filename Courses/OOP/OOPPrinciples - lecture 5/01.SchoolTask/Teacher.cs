namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Teacher : Person, IComment
    {
        public Teacher(string firstName, string secondName, string comment)
            : base(firstName, secondName, comment)
        {

        }
    }
}
