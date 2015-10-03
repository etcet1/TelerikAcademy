namespace Person
{
    using System;

    class Person
    {
        private string name;
        private int? age;

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int? Age {
            get { return this.age; }
            set { this.age = value; }
        }


        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string message = this.Name;
            message += this.Age == null ? " - age not specified" : " - " + this.Age + " years old";

            return message;
        }
    }
}
