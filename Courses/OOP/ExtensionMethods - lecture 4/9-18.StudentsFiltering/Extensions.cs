namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static void GetListOfStudentsWithNumberOfMarks(this Students[] students, int mark, int markCount)
        {
            var newStudents =
                            from student in students
                            where student.Marks.Count(x => x == mark) == markCount
                            select student;

            printStudents(newStudents.ToArray());
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