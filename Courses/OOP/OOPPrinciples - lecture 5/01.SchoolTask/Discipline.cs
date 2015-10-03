namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Discipline : IComment
    {

        public string Name { get; private set; }
        public int NumberOfLecturers { get; set; }
        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }

        public Discipline(string name, int numberOfLecturers, int numberOfExcercises, string comment)
        {
            this.Name = name;
            this.NumberOfLecturers = numberOfLecturers;
            this.NumberOfExercises = numberOfExcercises;
            this.Comment = comment;
        }

        public override string ToString()
        {
            return String.Format("{0} Leturers: {1}, Exercises: {2}", this.Name, this.NumberOfLecturers, this.NumberOfExercises);
        }

    }
}
