using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PearcePhanawongC968
{
    public class Outsourced : Part
    {
        public string companyName;

        public string CompName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public Outsourced(int partID, string name, decimal price, int Stock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;
            CompName = companyName;
        }
    }
}
