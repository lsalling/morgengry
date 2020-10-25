using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Book : Merchandise
    {
        public double Price { get; set; }
        public string Title { get; set; }

		public Book(string itemId, string title, double price)
        {
			this.ItemId = itemId;
			this.Price = price;
			this.Title = title;
        }

		public Book(string itemId, string title)
		{
			this.ItemId = itemId;
			this.Title = title;
		} 

		public Book(string itemId)
		{
			this.ItemId = itemId;
		} 

		public override double GetValue()
        {
			return this.Price;
        }

		public override string ToString()
		{
			return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
		}
	}
}
