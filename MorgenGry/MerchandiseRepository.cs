using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandise;

        public List<Merchandise> Merchandise
        {
            get { return this.merchandise; }
        }

        public MerchandiseRepository()
        {
            this.merchandise = new List<Merchandise>();
        }

        public void AddMerchandise(Merchandise merch)
        {
            this.merchandise.Add(merch);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            return this.merchandise.Find(x => x.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach(Merchandise merch in merchandise)
            {
                double price = Utility.GetValueOfMerchandise(merch);
                totalValue += price;
            }

            return totalValue;
        }
    }
}
