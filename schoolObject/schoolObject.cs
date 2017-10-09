using System;
using System.Collections.Generic;

namespace schoolObject
{
    public class schoolObject
    {
        //a collection of courses offered by a university
        private Dictionary<String, Course> courses;
        //a collection of students enrolled in university;
        private Dictionary<string, Student> students;
        public schoolObject()
        {
            this.courses = new Dictionary<String, Course>();
            this.students = new Dictionary<string, Student>();
        }

        public void EnrolStudent(Student student){
            students.Add(student.GetName(), student);
        }

        public void CourseSignOn(string studentName,Course course){
            Student student = students[studentName];
            if (student.canEnrolCourse(course) && course.CanEnrollStudent(student)){
                student.CourseSignOn(course); 
                course.EnrollStudent(student);
            }
        }

        public void Addcourse(String courseName, Course course){
            if (courses.ContainsKey(courseName) || courses.ContainsValue(course)){
                Console.WriteLine("can't write new course to school");
            } else{
                courses.Add(courseName, course);
            }
        }

        public void GPAReport(Student student){
			foreach (KeyValuePair<string, Student> entry in students)
			{
                Console.WriteLine($"{entry.Key}'s GPA is {entry.Value.GetGPA()}");
			}
        }

        public void TuitionFee(Student student){
            
        }
    }
}
