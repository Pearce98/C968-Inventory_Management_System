using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PearcePhanawongC968
{
    public abstract class Part
    {
        public int partID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

        public int PartID
        {
            get { return partID; }
            set { partID = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        public int Stock
        {
            get { return InStock; }
            set { InStock = value; }
        }

        public int min
        {
            get { return Min; }
            set { Min = value; }
        }

        public int max
        {
            get { return Max; }
            set { Max = value; }
        }
    }
}
