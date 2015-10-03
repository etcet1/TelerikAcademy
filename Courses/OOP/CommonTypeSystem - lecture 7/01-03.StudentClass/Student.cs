namespace CommonTypeSystem
{
    using System;
    using System.Collections;

    public enum Specialties
    {
        Telecommunications, Marketing, Business, Physics, Mathematics, IT
    }

    public enum Universities
    {
        SU, UNSS, TU, NBU, VVTU
    }

    public enum Faculties
    {
        Law, Mathematics, Biology, Business, Management, Telecommunication
    }

    class Student : IComparable<Student>, ICloneable
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private int ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private string course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

        //TO DO: data filtering
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public int SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        // constructors
        public Student(string firstName, string secondName, string lastName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
        }

        public Student(string firstName, string secondName, string lastName, string address, string mobilePhone, string course, int ssn, Specialties specialty, Universities university, Faculties faculty)
            : this(firstName, secondName, lastName)
        {
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Course = course;
            this.SSN = ssn;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " Student number:" + this.SSN;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public object Clone()
        {
            Student clonedStundent = new Student(
            this.FirstName,
            this.SecondName,
            this.LastName,
            this.Address,
            this.MobilePhone,
            this.Course,
            this.SSN,
            this.Specialty,
            this.University,
            this.Faculty
            );

            return clonedStundent;
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName.CompareTo(student.FirstName) != 0)
            {
                return firstName.CompareTo(student.firstName);
            }
            else if (this.SecondName.CompareTo(student.SecondName) != 0)
            {
                return this.SecondName.CompareTo(student.SecondName);
            }
            else if (this.LastName.CompareTo(student.LastName) != 0)
            {
                return lastName.CompareTo(student.LastName);
            }
            else
            {
                return this.SSN.CompareTo(student.SSN);
            }
        }
    }
}