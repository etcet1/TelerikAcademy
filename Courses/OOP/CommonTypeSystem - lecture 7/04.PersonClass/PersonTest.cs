namespace Person
{
    using System;

    class PersonTest
    {
        public static void Main()
        {
            Person firstPerson = new Person("Georgi Georgiev", 36);
            Person secondPerson = new Person("Pesho Pesshev", null);
            Person thirdPerson = new Person("Joro Petrov");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}
