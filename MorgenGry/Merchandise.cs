using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public abstract double GetValue();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
