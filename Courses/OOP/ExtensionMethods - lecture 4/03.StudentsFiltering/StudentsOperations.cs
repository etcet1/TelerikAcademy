namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsOperations
    {
        static void Main(string[] args)
        {
            Students[] students = {
                new Students(
                    "Pesho", 
                    "Ivanov",
                    20),
                new Students(
                    "Georgi", 
                    "Dimitrov",
                    18),
                new Students(
                    "Ivailo", 
                    "Georgiev",
                    19),
                new Students(
                    "Aleksandar", 
                    "Lozov",
                    29),
                new Students(
                    "Gaco",
                    "Bacov",
                    23),
                new Students(
                    "Atanas",
                    "Palamarski",
                    23)};

            Console.WriteLine("Students whose first name is before its last name alphabetically.");
            Students.GetStudentsComparedByLastName(students);
            Console.WriteLine();


            Console.WriteLine("Students with age between 18 and 24");
                var youngerStudents =
                    from student in students
                    where student.Age >= 18 && student.Age <= 24
                    select student;
            Students.printStudents(youngerStudents.ToArray());
            Console.WriteLine();

            Console.WriteLine("Sort students with order by and then by");
            var descendingOrderOfStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Students.printStudents(descendingOrderOfStudents.ToArray());
            Console.WriteLine();

            Console.WriteLine("Sort students with order by and then by with LINQ");
            var descendingOrderOfStudentsWithLINQ =
                from student in students
                orderby student.FirstName descending,
                student.LastName descending
                select student;
            Students.printStudents(descendingOrderOfStudentsWithLINQ.ToArray());
        }
    }
}