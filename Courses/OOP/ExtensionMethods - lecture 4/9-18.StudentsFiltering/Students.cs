namespace ExtensionMethods
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Students
    {
        private string firstname;
        private string lastname;
        private string facultyNumber;
        private string telephone;
        private string email;
        private List<int> marks;
 
        public Students()
        {

        }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Students(string firstName, string lastName, string facultyNumber, string telephone, string email, List<int> marks, int groupnumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.Marks = marks;
            this.LastName = lastName;
            this.GroupNumber = groupnumber;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string FacultyNumber { get; set; }
  
        public string Telephone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return string.Format("Full name of the student: {0}", this.FirstName + " " + this.LastName);
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