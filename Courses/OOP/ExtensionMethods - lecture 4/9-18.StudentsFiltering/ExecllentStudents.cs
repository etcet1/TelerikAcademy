namespace ExtensionMethods
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class ExcellentStudents
    {
        private string fullname;
        private List<int> marks;

        public ExcellentStudents()
        {

        }

        public ExcellentStudents(string fullName, List<int> marks)
        {
            this.Fullname = fullName;
            this.Marks = marks;
        }

        public string Fullname { get; private set; }

        public List<int> Marks { get; set; }

        public override string ToString()
        {
            return string.Format("Full name of the student: {0}", this.Fullname);
        }

        public static void PrintStudents(IEnumerable students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}