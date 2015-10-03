namespace CommonTypeSystem
{
    using System;

    class StudentTest
    {
        public static void Main()
        {
            Student firstStudent = new Student("Pesho", "Georgiev", "Ivanov", "Sofia", "+3849384398",
                "pesho@test.net", 3122, Specialties.Telecommunications, Universities.TU, Faculties.Law);
 
            Student secondStudent = new Student("Dancho", "Ivanov", "Petrov", "Plovdiv", "039483439",
                "pesho@test.net", 23453, Specialties.IT, Universities.NBU, Faculties.Mathematics);
 
            Console.WriteLine("First student HashCode: " + firstStudent.GetHashCode());
            Console.WriteLine("Second student HashCode: " + secondStudent.GetHashCode());
            Console.WriteLine("First student equals second student: " + firstStudent.Equals(secondStudent));
            Console.WriteLine("First student == second student: " + (firstStudent == secondStudent));
            Console.WriteLine("First student != second student: " + (firstStudent != secondStudent));
            Console.WriteLine();
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine();

            Student thirdStudent = (Student)secondStudent.Clone();

            Console.WriteLine("Second student == third student: " + (secondStudent == thirdStudent));
            Console.WriteLine("Second student != third student: " + (secondStudent != thirdStudent));
            Console.WriteLine("Second student.CompareTo(third student): " + secondStudent.CompareTo(thirdStudent));
            Console.WriteLine("First student.CompareTo(Second student): " + firstStudent.CompareTo(secondStudent));
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine(thirdStudent.ToString());
        }
    }
}
