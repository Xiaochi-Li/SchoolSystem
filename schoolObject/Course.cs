using System;
using System.Collections.Generic;

namespace schoolObject
{
    public class Course
    {
        private string courseName;
        private int capacity;
        private int credit;
        private int currentStudentNum;
        private List<Student> students;
		public Course(int capacity,int credit, string courseName)
        {
            this.capacity = capacity;
            this.credit = credit;
            currentStudentNum = 0;
            this.students = new List<Student>();
        }

        public int GetCurrentStudentNum(){
            return this.currentStudentNum;
        }

        public int GetCredit(){
            return this.credit;
        }

        public string GetCourseName(){
            return this.courseName;
        }

        public void EnrollStudent(Student student){
            students.Add(student);

        }

        public bool CanEnrollStudent(Student student){
            if(students.Count >= currentStudentNum){
                Console.WriteLine($"No more room for a new student");
                return false;
            } else {
                return true;
            }
        }
    }
}
