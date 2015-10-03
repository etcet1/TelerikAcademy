namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsFiltering
    {
        public static void GetStudentsFromGroup2(Students[] students)
        {
            var newStudents =
               from student in students
               where student.GroupNumber == 2
               orderby student.FirstName
               select student;
            printStudents(newStudents.ToArray());
        }

        public static void GetStudentsWithEmailInAbv(Students[] students)
        {
            var newStudents =
               from student in students
               where student.Email.Contains("@abv.bg")
               select student;
            printStudents(newStudents.ToArray());
        }

        public static void GetStudentsWithPhoneInSofia(Students[] students)
        {
            var newStudents =
               from student in students
               where student.Telephone.StartsWith("02")
               select student;
            printStudents(newStudents.ToArray());
        }

        public static List<ExcellentStudents> GetStudentsWithAtLeastOneExcellentMark(Students[] students)
        {
            List<ExcellentStudents> excellentStudents = new List<ExcellentStudents>();
            var newStudents =
               from student in students
               where student.Marks.Contains(6)
               select student;

            foreach (var student in newStudents)
            {
                var execellentStudent = new ExcellentStudents(student.FirstName + " " + student.LastName, student.Marks);
                excellentStudents.Add(execellentStudent);
            }
            return excellentStudents;
        }
        public static void GetStudentsEnrolledIn2006(Students[] students)
        {
            var newStudents =
               from student in students
               where student.FacultyNumber.EndsWith("06")
               select student;
            foreach (var student in newStudents)
            {
                Console.WriteLine(student + " - marks: " + string.Join(", ",student.Marks));
            }
        }

        public static void printStudents(Students[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}