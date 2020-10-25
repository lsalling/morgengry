using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class ValuableRepository
    {
        public List<IValuable> valuables;

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
                        return foundValuable = merchandise;
                }

                if (valuable is Course)
                {
                    Course course = valuable as Course;

                    if(course.Name == id)
                        return foundValuable = course;
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
    }
}
