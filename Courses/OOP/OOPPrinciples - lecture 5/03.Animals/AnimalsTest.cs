namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class AnimalsTest
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog( 4, "Dog1", "female"),
                new Dog( 2, "Dog2", "male"),
                new Dog( 8, "Dog3", "female"),
                new Dog( 11, "Dog4", "male")
            };
            List<Frog> frogs = new List<Frog>
            {
                new Frog( 2, "Frog1", "male"),
                new Frog( 1, "Frog2", "male"),
                new Frog( 9, "Frog3", "female"),
                new Frog( 3, "Frog4", "female")
            };
            List<Cat> cats = new List<Cat>
            {
                new Kitten( 3, "Cat1"),
                new TomCat( 5, "Cat2"),
                new Kitten( 2, "Cat3"),
                new TomCat( 1, "Cat4")
            };

            dogs[2].PlaySound();

            cats[1].IdentifyAnimal();

            frogs[3].IdentifyAnimal();

            Console.WriteLine("The average age of the dogs is " + Animal.AverageAge(dogs) + " years");
            Console.WriteLine("The Average age of the frogs is " + Animal.AverageAge(frogs) + " years");
            Console.WriteLine("The average age of the cats is " + Animal.AverageAge(cats) + " years");
        }
    }
}
