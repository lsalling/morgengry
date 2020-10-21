using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Controller
    {
        private MerchandiseRepository merchandiseRepo;
        private CourseRepository courseRepo;

        public MerchandiseRepository MerchandiseRepo
        {
            get { return this.merchandiseRepo; }
        }

        public CourseRepository CourseRepo
        {
            get { return this.courseRepo; }
        }

        public Controller()
        {
            this.merchandiseRepo = new MerchandiseRepository();
            this.courseRepo = new CourseRepository();
        }

        public void AddToList(Book book)
        {
            merchandiseRepo.AddMerchandise(book);
        }

        public void AddToList(Amulet amulet)
        {
            merchandiseRepo.AddMerchandise(amulet);
        }

        public void AddToList(Course course)
        {
            courseRepo.AddCourse(course);
        }
    }
}
