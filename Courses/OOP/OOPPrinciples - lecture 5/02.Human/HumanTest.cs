namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HumanTest
    {
        public static void Main()
        {
            List<Student> students = new List<Student>{
                new Student(4, "Pesho", "Ivanov"),
                new Student(2, "Georgi", "Atanasov"),
                new Student(5, "Gaco", "Bacov")
            };

            var sortedStudents =
                   from student in students
                   orderby student.Grade descending
                   select student;

            List<Worker> workers = new List<Worker>{
                new Worker(8, 8.50M, "Worker", "Name"),
                new Worker(6, 7.25M, "Worker2", "Name"),
                new Worker(4, 10M, "Worker3", "Name")
            };

            var sortedWorkers =
                   from worker in workers
                   orderby worker.MoneyPerHour() descending
                   select worker;

            List<Human> bothGroups = new List<Human>();

            bothGroups.AddRange(students);
            bothGroups.AddRange(workers);

            var sortedHumans =
               from human in bothGroups
               orderby human.FirstName, human.SecondName
               select human;
        }
    }
}