using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolProject;
using System.Collections.Generic;

namespace TestSchoolProject
{
    [TestClass]
    public class UnitTest1
    {
        // Students
        [TestMethod]
        public void TestInitializingStudent()
        {
            Assert.IsInstanceOfType(new Student("Test"), typeof(Student));
        }

        [TestMethod]
        public void TestStudentUniqueNumber()
        {
            Student test = new Student("UniqueTestIdentifier");
            Assert.IsTrue(test.UniqueNumber == 10000, 
                "Student's unique number is different than expected. (Expected 10003)" + test.UniqueNumber);
        }

        [TestMethod]
        public void TestStudentName()
        {
            Student test = new Student("Test");
            Assert.IsTrue(test.Name == "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyStudentName()
        {
            Student test = new Student("");
        }

        // Course
        [TestMethod]
        public void TestInitializingCourse()
        {
            Assert.IsInstanceOfType(new Course("Test"), typeof(Course));
        }

        [TestMethod]
        public void TestInitializingStudentsEnlistedInCourseList()
        {
            School test = new School(new List<Student>(), new List<Course>());
            Assert.IsInstanceOfType(test.Courses, typeof(List<Course>));
        }

        [TestMethod]
        public void TestStudentJoinedCourse()
        {
            Student test = new Student("Test");
            Course english = new Course("English");
            english.JoinCourse(test);
            Assert.IsTrue(english.EnlistedStudents.Count == 1, "Students in course count is different than expected. (Expected 1)");
        }

        [TestMethod]
        public void TestStudentWasRemovedFromCourse()
        {
            Student test = new Student("Test");
            Course english = new Course("English");
            english.JoinCourse(test);
            english.RemoveFromCourse(test);
            Assert.IsTrue(english.EnlistedStudents.Count == 0, "Students in course count is different than expected. (Expected 0)");
        }

        [TestMethod]
        public void TestCourseName()
        {
            Course test = new Course("Test");
            Assert.IsTrue(test.Name == "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMaximumNumberOfStudentsInCourse()
        {
            Course eng = new Course("English");

            for (int i = 0; i < 32; i++)
            {
                eng.JoinCourse(new Student("Test Student"));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemovingStudentsFromEmptyCourse()
        {
            Course eng = new Course("English");
            eng.RemoveFromCourse(new Student("Test Student"));
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestRemovingNonExistentStudentFromCourse()
        {
            Course eng = new Course("English");
            Student testStudent = new Student("Test Student");
            eng.JoinCourse(testStudent);
            eng.RemoveFromCourse(new Student("NonExistent"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyCourseName()
        {
            Course eng = new Course("");
        }

        // School
        [TestMethod]
        public void TestInitializingSchool()
        {
            Assert.IsInstanceOfType(new School(), typeof(School));
        }

        [TestMethod]
        public void TestInitializingStudentsList()
        {
            School test = new School(new List<Student>(), new List<Course>());
            Assert.IsInstanceOfType(test.Students, typeof(List<Student>));
        }

        [TestMethod]
        public void TestInitializingCoursesList()
        {
            School test = new School(new List<Student>(), new List<Course>());
            Assert.IsInstanceOfType(test.Courses, typeof(List<Course>));
        }
    }
}
