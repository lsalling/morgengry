using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MorgenGry
{
    public class Utility
    {
        public static double GetValueOfCourse(Course course)
        {
            double COST_PER_HOUR = 875.00;
            return Math.Ceiling((double)course.DurationInMinutes / 60) * COST_PER_HOUR;
        }

        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20;
                case Level.high:
                    return 27.5;
                default:
                    return 0.0;
            }
        }
    }
}
