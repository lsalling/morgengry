using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public static class Utility
    {
        static double LowQualityValue;
        static double MediumQualityValue;
        static double HighQualityValue;
        static double CourseHourValue;

        static Utility()
        {
            LowQualityValue = 12.5;
            MediumQualityValue = 20.0;
            HighQualityValue = 27.5;
            CourseHourValue = 875.0;
        }

        public static double GetValueOfCourse(Course course)
        {
            return Math.Ceiling((double)course.DurationInMinutes / 60) * CourseHourValue;
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if(merchandise is Book)
            {
                Book book = merchandise as Book;
                return book.Price;
            }

            if(merchandise is Amulet)
            {
                Amulet amulet = merchandise as Amulet;
                switch (amulet.Quality)
                {
                    case Level.low:
                        return LowQualityValue;
                    case Level.medium:
                        return MediumQualityValue;
                    case Level.high:
                        return HighQualityValue;
                    default:
                        return 0.0;
                }
            }

            return 0.00;
        }
    }
}
