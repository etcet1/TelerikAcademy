namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animal
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine("I am " + GetType().Name);
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            double averageAge = animals.Average((x) => x.Age);

            return averageAge;
        }
    }
}
