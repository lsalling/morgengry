using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
