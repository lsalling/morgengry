using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Course : IValuable
    {
        public static double CourseHourValue = 875.00;

        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int duration)
        {
            this.Name = name;
            this.DurationInMinutes = duration;
        }

        public double GetValue()
        {
            return Math.Ceiling((double)this.DurationInMinutes / 60) * CourseHourValue;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Duration in Minutes: {1}, Pris pr påbegyndt time: {2}", this.Name, this.DurationInMinutes, this.GetValue());
        }
    }
}
