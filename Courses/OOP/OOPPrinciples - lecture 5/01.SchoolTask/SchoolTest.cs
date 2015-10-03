namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolTest
    {
        static void Main()
        {
            Teacher firstTeacher = new Teacher("Georgi", "Georgiev", "Great teacher");
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(firstTeacher);

            Discipline microBiology = new Discipline("MicroBiology", 4, 5, "New discipline");
            Discipline nanoBiology = new Discipline("NanoBiology", 10, 9, "Old discipline");

            List<Discipline> semester = new List<Discipline>();
            semester.Add(microBiology);
            semester.Add(nanoBiology);

            Class biology = new Class("BiologyID", teachers, semester, "Our first class");

            foreach (var discipline in biology.Disciplines)
            {
                Console.WriteLine(discipline.Name);
            }

            foreach (var teacher in biology.Teachers)
            {
                Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine(teacher.Comment);
            }
        }
    }
}
