using System;

namespace SchoolProject
{
    public class Student
    {
        private static int numberIdentifier = 10000;
        private string name;
        private int uniqueNumber;

        public Student(string name)
        {
            this.Name = name;
            this.UniqueNumber = numberIdentifier;
            numberIdentifier++;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get 
            {
                return this.uniqueNumber;
            }
            private set
            {
                this.uniqueNumber = value;
            }
        }
    }
}
