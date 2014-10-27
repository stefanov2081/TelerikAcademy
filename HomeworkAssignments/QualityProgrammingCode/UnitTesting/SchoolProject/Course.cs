using System;
using System.Collections.Generic;

namespace SchoolProject
{
    public class Course
    {
        private string name;
        private List<Student> enlistedStudents;

        public Course(string name)
        {
            this.Name = name;
            this.enlistedStudents = new List<Student>();
        }

        public Course(string name, List<Student> enlistedStudents)
        {
            this.Name = name;
            this.EnlistedStudents = enlistedStudents;
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
                    throw new ArgumentException("Course name can not be empty");
                }

                this.name = value;
            }
        }

        public List<Student> EnlistedStudents
        {
            get
            {
                return this.enlistedStudents;
            }
            private set
            {
                if (value.Count > 30)
                {
                    throw new ArgumentOutOfRangeException("You have reached the maximum number of students for this course");
                }

                this.enlistedStudents = value;
            }
        }

        public void JoinCourse(Student student)
        {
            if (EnlistedStudents.Count > 29)
            {
                throw new ArgumentOutOfRangeException("You have reached the maximum number of students for this course");
            }
            this.EnlistedStudents.Add(student);
        }

        public void RemoveFromCourse(Student student)
        {
            if (EnlistedStudents.Count < 1)
            {
                throw new ArgumentOutOfRangeException("There are no students in this course");
            }
            else if (this.EnlistedStudents.IndexOf(student) < 0)
            {
                throw new KeyNotFoundException("Student " + student.Name + "could not be found");
            }

            this.EnlistedStudents.Remove(student);
        }
    }
}
