using System.Collections.Generic;

namespace SchoolProject
{
    public class School
    {
        private List<Student> students;
        private List<Course> courses;

        public School()
        { 
        }

        public School(List<Student> students, List<Course> courses)
        {
            this.Students = students;
            this.Courses = courses;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set 
            {
                this.students = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
    }
}
