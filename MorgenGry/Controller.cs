using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Controller
    {
        private List<Book> books;
        private List<Amulet> amulets;
        private List<Course> courses;

        public List<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }

        public List<Amulet> Amulets
        {
            get { return this.amulets; }
            set { this.amulets = value; }
        }

        public List<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public Controller()
        {
            books = new List<Book>();
            amulets = new List<Amulet>();
            courses = new List<Course>();
        }

        public void AddToList(Course course)
        {
            Courses.Add(course);
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
