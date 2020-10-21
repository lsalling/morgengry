using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Amulet : Merchandise
    {
        public Level Quality { get; set; }

        public string Design { get; set; }

		public Amulet(string itemId, Level quality, string design)
        {
			this.ItemId = itemId;
			this.Quality = quality;
			this.Design = design;
        }

		public Amulet(string itemId, Level quality)
		{
			this.ItemId = itemId;
			this.Quality = quality;
		} 

		public Amulet(string itemId)
		{
			this.ItemId = itemId;
			this.Quality = Level.medium;
		} 

		public override string ToString()
		{
			return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
		}
    }
}
