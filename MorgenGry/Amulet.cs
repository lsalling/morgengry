using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Amulet
    {
		private string itemId;
		private string design;
		private Level quality;

		public string ItemId
		{
			get { return itemId; }
			set { itemId = value; }
		}

		public Level Quality
		{
			get { return quality; }
			set { quality = value; }
		}


		public string Design
		{
			get { return design; }
			set { design = value; }
		}

		public Amulet(string itemId, Level quality, string design)
        {
			this.itemId = itemId;
			this.quality = quality;
			this.design = design;
        }

		public Amulet(string itemId, Level quality): this (itemId, quality, "") {} 

		public Amulet(string itemId): this (itemId, Level.medium, "") {} 

		public override string ToString()
		{
			return $"ItemId: {itemId}, Quality: {quality}, Design: {design}";
		}
    }
}
