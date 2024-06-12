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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> moddedParts = new BindingList<Part>();

        public ModifyProduct(Product oldProduct)
        {
            InitializeComponent();

            //fills all the text boxes
            IDTextBox.Text = oldProduct.ProductID.ToString();
            NameTextBox.Text = oldProduct.Name;
            PriceTextBox.Text = oldProduct.Price.ToString();
            InventoryTextBox.Text = oldProduct.stock.ToString();
            MinTextBox.Text = oldProduct.min.ToString();
            MaxTextBox.Text = oldProduct.max.ToString();

            //All Parts Table
            AllPartsGrid.DataSource = Inventory.AllParts;
            //Parts associated with Product Table
            foreach (Part part in oldProduct.AssociatedParts)
            {
                moddedParts.Add(part);
            }
            AssociatedPartsGrid.DataSource = moddedParts;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //DESTROY THE PAGE
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Checks if text box is empty
            String searchValue = SearchTextBox.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter text to search");
                return;
            }

            //Searches for part and selects the row
            foreach (var currentPart in Inventory.AllParts)
            {
                if (currentPart.Name.Contains(searchValue))
                {
                    int searchID = currentPart.PartID - 1;
                    foreach (DataGridViewRow row in AllPartsGrid.Rows)
                    {
                        if (searchID == row.Index)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
            }
            //Displays if cannot find
            MessageBox.Show("Part couldn't be found.");
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            //Checks if part is already in the list
            foreach (var Part in moddedParts)
            {
                if ((Part)AllPartsGrid.CurrentRow.DataBoundItem == Part)
                {
                    MessageBox.Show("Part already included in associated parts.");
                    return;
                }
            }
            //Adds to list
            moddedParts.Add((Part)AllPartsGrid.CurrentRow.DataBoundItem);
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            //Check if there is a part in the list
            if (moddedParts.Count == 0)
            {
                MessageBox.Show("There are no items associated with this product.");
                return;
            }

            //confirmation of deleting the item
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //gets ID of part to delete
                int selectedRow = AssociatedPartsGrid.CurrentCell.RowIndex;
                int selectedID = Convert.ToInt32(AssociatedPartsGrid.Rows[selectedRow].Cells[0].Value);
                foreach (Part part in moddedParts)
                {
                    if (part.PartID == selectedID)
                    {
                        //Deletes part if match
                        moddedParts.Remove(part);
                        return;
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            //checks to make sure name isn't empty
            if (name.Length == 0)
            {
                MessageBox.Show("Please give the product a name.");
                return;
            }

            //gets all boxes info to save to new product
            int stock;
            int min;
            int max;
            decimal price;
            int ID;

            try
            {
                stock = int.Parse(InventoryTextBox.Text);
                min = int.Parse(MinTextBox.Text);
                max = int.Parse(MaxTextBox.Text);
                price = decimal.Parse(PriceTextBox.Text);
                ID = int.Parse(IDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Inventory, price, min, and max must be numeric values.");
                return;
            }

            stock = int.Parse(InventoryTextBox.Text);
            min = int.Parse(MinTextBox.Text);
            max = int.Parse(MaxTextBox.Text);
            price = decimal.Parse(PriceTextBox.Text);
            ID = int.Parse(IDTextBox.Text);

            //stock, min, and max need to line up appropriately
            if (min > max)
            {
                MessageBox.Show("Min must be less than the max");
                return;
            }

            if (stock > max || min > stock)
            {
                MessageBox.Show("Inventory needs to be less than the max and greater than the min.");
                return;
            }

            //Creates a new Product, adds all the parts to it, and saves it to inventory
            Product newProduct = new Product(ID, name, price, stock, min, max);
            foreach (Part part in moddedParts)
            {
                newProduct.addAssociatedPart(part);
            }
            Inventory.updateProduct(ID, newProduct);
            Close();
        }
    }
}
