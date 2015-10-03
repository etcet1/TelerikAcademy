namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Class : IComment
    {
        public string TextID { get; private set; }
        public List<Teacher> Teachers { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public string Comment { get; set; }

        public Class(string id, List<Teacher> teachers, List<Discipline> disciplines, string comment)
        {
            this.TextID = id;
            this.Teachers = new List<Teacher>(teachers);
            this.Disciplines = new List<Discipline>(disciplines);
            this.Comment = comment;
        }
    }
}
