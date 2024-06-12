using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearcePhanawongC968
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Inventory.testItems();

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            ProdGridView.DataSource = prodTable;

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.AllParts;
            PartGridView.DataSource = partTable;


        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        private void button1_Click(object sender, EventArgs e) //modify part button
        {
            if (PartGridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse)) 
            { 
                Inhouse partToMod = (Inhouse)PartGridView.CurrentRow.DataBoundItem;
                ModifyPart modPart = new ModifyPart(partToMod);
                modPart.Show();
            }
            else
            {
                Outsourced partToMod = (Outsourced)PartGridView.CurrentRow.DataBoundItem;
                ModifyPart modPart = new ModifyPart(partToMod);
                modPart.Show();
            }
            
        }

        private void addProd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void modProd_Click(object sender, EventArgs e)
        {
            Product prodToMod = (Product)ProdGridView.CurrentRow.DataBoundItem;
            ModifyProduct modProduct = new ModifyProduct(prodToMod);
            modProduct.Show();
        }

        private void button7_Click(object sender, EventArgs e) //Cancel Button
        {
            Close();
        }

        private void delPart_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = PartGridView.CurrentCell.RowIndex;
                int selectedID = Convert.ToInt32(PartGridView.Rows[selectedRow].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Part partToDelete = Inventory.lookupPart(selectedID);
                    foreach (Product product in Inventory.Products)
                    {
                        foreach (Part part in product.AssociatedParts)
                        {
                            if (partToDelete == part)
                            {
                                MessageBox.Show("Unable to delete part - Part is a part of a product.");
                                return;
                            }
                        }
                    }
                    Inventory.deletePart(partToDelete);
                }
            }
            catch
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void delProd_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = ProdGridView.CurrentCell.RowIndex;
                int selectedID = Convert.ToInt32(ProdGridView.Rows[selectedRow].Cells[0].Value);
                if (Inventory.lookupProduct(selectedID).AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Unable to delete - product has at least one part assigned to it.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
                Inventory.removeProduct(selectedID);
            }
            catch
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void button8_Click(object sender, EventArgs e) //part search button
        {
            String searchValue = PartSearchBar.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter text to search");
                return;
            }

            foreach (var currentPart in Inventory.AllParts)
            {
                if (currentPart.Name.Contains(searchValue))
                {
                    int searchID = currentPart.PartID - 1;
                    foreach (DataGridViewRow row in PartGridView.Rows)
                    {
                        if (searchID == row.Index)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                
            }
            MessageBox.Show("Part couldn't be found.");
        }

        private void ProdSearchButton_Click(object sender, EventArgs e)
        {
            String searchValue = ProductSearchBar.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter text to search");
                return;
            }

            foreach (var currentProd in Inventory.Products)
            {
                if (currentProd.Name.Contains(searchValue))
                {
                    int searchID = currentProd.ID - 1;
                    foreach (DataGridViewRow row in ProdGridView.Rows)
                    {
                        if (searchID == row.Index)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Product couldn't be found");
        }
    }
}
