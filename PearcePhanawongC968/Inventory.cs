using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearcePhanawongC968
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void testItems()
        {
            Product testProd1 = new Product(1,"Laptop",(decimal)1.99,3,1,5);
            Product testProd2 = new Product(2,"Desktop",(decimal)2.99,10,5,15);
            Product testProd3 = new Product(3,"Tablet",(decimal)3.99,100,30,150);

            Products.Add(testProd1);
            Products.Add(testProd2);
            Products.Add(testProd3);

            Part testPart1 = new Inhouse(1,"GPU",(decimal)1.99,3,1,5,100);
            Part testPart2 = new Inhouse(2,"Fan",(decimal)2.99,30,10,50,200);
            Part testPart3 = new Inhouse(3,"Power Supply",(decimal)3.99,300,100,500,300);
            
            AllParts.Add(testPart1);
            AllParts.Add(testPart2);
            AllParts.Add(testPart3);

            Part testPart4 = new Outsourced(4, "CPU", (decimal)1.99, 3, 1, 5, "Intel");
            Part testPart5 = new Outsourced(5, "RAM", (decimal)2.99, 3, 1, 5, "Corsair");
            Part testPart6 = new Outsourced(6, "Motherboard", (decimal)3.99, 3, 1, 5, "ASUS");

            AllParts.Add(testPart4);
            AllParts.Add(testPart5);
            AllParts.Add(testPart6);
        }


        public static void addProduct(Product product)
        {
            Products.Add(product);
        } 

        public static bool removeProduct(int ID)
        {
            foreach (Product prod in Products) 
            {
                if (prod.ProductID == ID)
                {
                    Products.Remove(prod);
                    int i = 1;
                    foreach (Product change in Products)
                    {
                        change.ProductID = i;
                        i++;
                    }
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int ID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == ID)
                {
                    return prod;
                }
            }
            Product noProdInList = null;
            return noProdInList;
        }

        public static void updateProduct(int ID, Product prod)
        {
            foreach (Product oldProd in Products)
            {
                if (oldProd.ProductID == ID)
                {
                    oldProd.ProductID = prod.ProductID;
                    oldProd.Name = prod.Name;
                    oldProd.Price = prod.Price;
                    oldProd.InStock = prod.InStock;
                    oldProd.Min = prod.Min;
                    oldProd.Max = prod.Max;
                    oldProd.AssociatedParts = prod.AssociatedParts;
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                int i = 1;
                foreach (Part change in AllParts)
                {
                    change.PartID = i;
                    i++;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part lookupPart(int ID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            Part noPartInList = null;
            return noPartInList;
        }

        public static void updatePart(int ID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                Part partInList = AllParts[i];
                if (partInList.PartID == ID)
                {
                    AllParts[i] = part;
                    break;
                }
            }

        }
    }
}
