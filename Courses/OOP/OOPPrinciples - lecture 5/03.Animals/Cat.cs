namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Cat : Animal, ISound
    {
        public Cat(int age, string name, string sex)
            : base(age, name, sex)
        {
        }
        public void PlaySound()
        {
            Console.WriteLine("The cat " + this.Name + " says \"Myauuu\".");
        }
    }
}