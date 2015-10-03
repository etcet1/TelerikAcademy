namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }
        public void PlaySound()
        {
            Console.WriteLine("The frog " + this.Name + " says \"Kuak-kuak\".");
        }
    }
}