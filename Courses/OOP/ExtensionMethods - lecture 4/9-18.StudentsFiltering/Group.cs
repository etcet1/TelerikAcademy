namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public class Group
    {
        private int groupNumber;
        private string department;

        public Group(int currentGroupNumber, string currentDepartment)
        {
            this.GroupNumber = currentGroupNumber;
            this.Department = currentDepartment;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }
    }
}