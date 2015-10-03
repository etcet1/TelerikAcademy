namespace ExtensionMethods
{

        using System;
        using System.Collections.Generic;
        using System.Linq;

        public class Students
        {
            private string firstName;
            private string lastName;
            private int? age;

            public Students(string firstName, string lastName)
                : this(firstName, lastName, null)
            {
            }

            public Students(string firstName, string lastName, int? age)
            {
                 this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
            }

            public string FirstName { 
                get 
                { 
                    return this.firstName;
                }
                set
                {
                    this.firstName = value;
                }
            }

            public string LastName {
                get
                {
                    return this.lastName;
                }
                set
                {
                    this.lastName = value;
                }
            }

            public int? Age
            {

                get 
                { 
                    return this.age; 
                }
                set
                {
                    if (age < 0 || age > 120)
                    {
                        throw new ArgumentException("Invalid age!");
                    }
                    this.age = value;
                }
            }

            public static void printStudents(Students[] students)
            {
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            public static void GetStudentsComparedByLastName(Students[] students)
            {
                var newStudents =
                   from student in students
                   where student.FirstName.CompareTo(student.LastName) < 0
                   select student;
                printStudents(newStudents.ToArray());
            }

            public static void GetStudentsComparedByAgeBetween18And24(Students[] students)
            {
                var newStudents =
                   from student in students
                   where student.Age >= 18 && student.Age <=24 
                   select student;
                printStudents(newStudents.ToArray());
            }

            public override string ToString()
            {
                return string.Format(this.FirstName + " " + this.LastName + " " + this.Age);
            }
        }
    

}
