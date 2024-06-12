using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearcePhanawongC968
{
    public class Product
    {
        //init properties
        public int ID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID 
        { 
            get { return ID; }
            set { ID = value; }
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
        public int stock 
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

        public Product (int ID, string name, decimal price, int stock, int min, int max)
        {
            ProductID = ID;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int ID)
        {
            //searches for part and deletes if ID matches, returns false if no match
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == ID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int ID)
        {
            //returns a part from looking up ID
            foreach(Part part in AssociatedParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
