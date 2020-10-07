using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Book
    {
		private string itemId;
		private string title;
		private double price;

		public string ItemId
		{
			get { return itemId; }
			set { itemId = value; }
		}

		public double Price
		{
			get { return price; }
			set { price = value; }
		}


		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		public Book(string itemId, string title, double price)
        {
			this.itemId = itemId;
			this.price = price;
			this.title = title;
        }

		public Book(string itemId, string title): this (itemId, title, 0) {} 

		public Book(string itemId): this (itemId, "", 0) {} 

		public override string ToString()
		{
			return $"ItemId: {itemId}, Title: {title}, Price: {price}";
		}
	}
}
