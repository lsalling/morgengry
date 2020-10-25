using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MorgenGry
{
    public class ValuableRepository : IPersistance
    {
        public List<IValuable> valuables;
        private StreamWriter sw;
        private StreamReader sr;
        private const string DEFAULT_SAVE_FILE = "ValuableRepository.txt";

        public ValuableRepository()
        {
            this.valuables = new List<IValuable>();
        }


        public void AddValuable(IValuable valuable)
        {
            this.valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable foundValuable = null;

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise)
                {
                    Merchandise merchandise = valuable as Merchandise;
                    if (merchandise.ItemId == id)
                        foundValuable = merchandise;
                }

                if (valuable is Course)
                {
                    Course course = valuable as Course;

                    if(course.Name == id)
                        foundValuable = course;
                }
            }

            return foundValuable;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach(IValuable valuable in valuables)
            {
                double price = valuable.GetValue();
                totalValue += price;
            }

            return totalValue;
        }

        public int Count()
        {
            return this.valuables.Count;
        }

        private const bool APPEND = false;

        public void Save()
        {
            // Open stream to argument file and override existing file if it exists (don't append).
            this.sw = new StreamWriter(DEFAULT_SAVE_FILE, APPEND);

            foreach (IValuable o in this.valuables)
            {
                if (o is Book)
                {
                    Book book = o as Book;
                    sw.WriteLine("{0};{1};{2};{3}", "BOG", book.ItemId, book.Title, book.Price);
                }

                if (o is Amulet)
                {
                    Amulet amulet = o as Amulet;
                    sw.WriteLine("{0};{1};{2};{3}", "AMULET", amulet.ItemId, amulet.Quality, amulet.Design);
                }

                if (o is Course)
                {
                    Course course = o as Course;
                    sw.WriteLine("{0};{1};{2}", "COURSE", course.Name, course.DurationInMinutes);
                }
            }

            this.sw.Close();
        }

        public void Save(string fileName)
        {
            // Open stream to argument file and override existing file if it exists (don't append).
            this.sw = new StreamWriter(fileName, APPEND);

            foreach (IValuable o in this.valuables)
            {
                if (o is Book)
                {
                    Book book = o as Book;
                    sw.WriteLine("{0};{1};{2};{3}", "BOG", book.ItemId, book.Title, book.Price);
                }

                if (o is Amulet)
                {
                    Amulet amulet = o as Amulet;
                    sw.WriteLine("{0};{1};{2};{3}", "AMULET", amulet.ItemId, amulet.Quality, amulet.Design);
                }

                if (o is Course)
                {
                    Course course = o as Course;
                    sw.WriteLine("{0};{1};{2}", "COURSE", course.Name, course.DurationInMinutes);
                }
            }

            this.sw.Close();
        }

        public void Load()
        {
            this.sr = new StreamReader(DEFAULT_SAVE_FILE);
            string line;

            while((line = sr.ReadLine()) != null)
            {
                string[] o;
                o = line.Split(";");

                switch (o[0])
                {
                    case "BOG":
                        Book book = new Book(o[1], o[2], double.Parse(o[3]));
                        AddValuable(book);
                        break;
                    case "AMULET":
                        Amulet amulet = new Amulet(o[1], (Level)Enum.Parse(typeof(Level), o[2]), o[3]);
                        AddValuable(amulet);
                        break;
                    case "COURSE":
                        Course course = new Course(o[1], int.Parse(o[2]));
                        AddValuable(course);
                        break;
                    default:
                        break;
                }
            }

            this.sr.Close();
        }

        public void Load(string fileName)
        {
            this.sr = new StreamReader(fileName);
            string line;

            while((line = sr.ReadLine()) != null)
            {
                string[] o;
                o = line.Split(";");

                switch (o[0])
                {
                    case "BOG":
                        Book book = new Book(o[1], o[2], double.Parse(o[3]));
                        AddValuable(book);
                        break;
                    case "AMULET":
                        Amulet amulet = new Amulet(o[1], (Level)Enum.Parse(typeof(Level), o[2]), o[3]);
                        AddValuable(amulet);
                        break;
                    case "COURSE":
                        Course course = new Course(o[1], int.Parse(o[2]));
                        AddValuable(course);
                        break;
                    default:
                        break;
                }
            }

            this.sr.Close();
        }
    }
}
