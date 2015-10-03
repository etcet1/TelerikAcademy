namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsFilteringTest
    {
        static void Main(string[] args)
        {
            Students[] students = {
                new Students(
                    "Pesho", 
                    "Ivanov",
                    "2006", 
                    "021234567", 
                    "email@abv.bg",
                    new List<int>(){2,3,2,5,6,6},
                    15),
                new Students(
                    "Georgi", 
                    "Dimitrov",
                    "2005", 
                    "0885242442", 
                    "email@gmail.com", 
                    new List<int>(){5,5,4,5,4,6},
                    16),
                new Students(
                    "Ivailo", 
                    "Georgiev",
                    "2012", 
                    "0899542311", 
                    "user@mail.com", 
                    new List<int>(){5,5,4,5,4,6},
                    17),
                new Students(
                    "Aleksandar", 
                    "Lozov",
                    "2014", 
                    "0899542211", 
                    "user2@mail.com", 
                    new List<int>(){4,4,4,5,4,4},
                    2),
                new Students(
                    "Gaco",
                    "Bacov",
                    "2009", 
                    "0199542311", 
                    "user3@mail.com", 
                    new List<int>(){2,2,2,2,2,2},
                    5),
                new Students(
                    "Atanas",
                    "Palamarski",
                    "2015", 
                    "075163638", 
                    "gaco@outlook.com", 
                    new List<int>(){5,5,3,5,4,5},
                    7)};

            Console.WriteLine("Students whose group number is 2.");
            StudentsFiltering.GetStudentsFromGroup2(students);
            Console.WriteLine();

            Console.WriteLine("Students whose e-mail is in abv.bg.");
            StudentsFiltering.GetStudentsWithEmailInAbv(students);
            Console.WriteLine();

            Console.WriteLine("Students who live in Sofia.");
            StudentsFiltering.GetStudentsWithPhoneInSofia(students);
            Console.WriteLine();


            Console.WriteLine("Students who has at least one mark 6.");
            ExcellentStudents.PrintStudents(StudentsFiltering.GetStudentsWithAtLeastOneExcellentMark(students));
            Console.WriteLine();


            Console.WriteLine("Students who has exactly two marks 2.");
            Extensions.GetListOfStudentsWithNumberOfMarks(students, 2, 2);
            Console.WriteLine();

            Console.WriteLine("Students that enrolled in 2006.");
            StudentsFiltering.GetStudentsEnrolledIn2006(students);
            Console.WriteLine();

        }
    }
}
