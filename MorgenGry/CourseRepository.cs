using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class CourseRepository
    {
        private List<Course> courses;

        public List<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
        public CourseRepository()
        {
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            return Courses.Find(x => x.Name == name);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach(Course course in Courses)
            {
                double value = Utility.GetValueOfCourse(course);
                totalValue += value;
            }

            return totalValue;
        }
    }
}
