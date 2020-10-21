using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Course
    {
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

        public override string ToString()
        {
            return string.Format("Name: {0}, Duration in Minutes: {1}", this.Name, this.DurationInMinutes);
        }
    }
}
