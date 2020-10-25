using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Amulet : Merchandise
    {
        private double lowQualityValue = 12.5;
        private double mediumQualityValue = 20;
        private double highQualityValue = 27.5;

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

		public override double GetValue()
        {
            switch (this.Quality)
            {
                case Level.low:
                    return this.lowQualityValue;
                case Level.medium:
                    return this.mediumQualityValue;
                case Level.high:
                    return this.highQualityValue;
                default:
                    return 0.0;
            }
        }

		public override string ToString()
		{
			return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
		}
    }
}
