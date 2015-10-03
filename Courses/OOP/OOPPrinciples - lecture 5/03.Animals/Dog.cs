namespace Animals
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Dog : Animal, ISound
    {
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public void PlaySound()
        {
            Console.WriteLine("The dog " + this.Name + " says \"Bau-bau\".");
        }

    }
}