using System;
using System.Collections.Generic;
namespace schoolObject
{
    public class Student
    {

        private float currentGPA;
        private string name;
        private int currentCredit;
        private int creditLimit;
        private HashSet<Course> courses;
        public Student(float currentGPA, int creditLimit, string name)
        {
            this.currentGPA = currentGPA;
            this.creditLimit = creditLimit;
            this.courses = new HashSet<Course>();
            this.currentCredit = 0;
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public bool canEnrolCourse(Course course)
        {
            if (course.GetCredit() + this.currentCredit <= creditLimit)
            {
                if (this.courses.Contains(course))
                {
                    Console.WriteLine($"{course.GetCourseName()} is sign on already");
                    return false;
                }
                else
                {
                    Console.WriteLine($"{course.GetCourseName()} is avaliable");
                    return true;
                }
            }
            else
            {
                Console.WriteLine($"insufficient credit for course {course.GetCourseName()}");
                return false;
            }
        }
        public void CourseSignOn(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"Sign on course: {course.GetCourseName()}");
            this.AddCurrentCredit(course.GetCredit());
        }

        public int GetCreditLimit()
        {
            return creditLimit;
        }

        public float GetGPA()
        {
            return currentGPA;
        }

        public int GetTuitionFee(){
			int tuitionFee = 0;
            tuitionFee = this.courses.Count * 100;
            return tuitionFee;
        }

        private void AddCurrentCredit(int unit){
            currentCredit += unit;
        }

    }
}
