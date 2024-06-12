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
    public partial class AddPart : Form
    {

        //new part ID
        int newPartID = Inventory.AllParts.Count + 1;
        

        public AddPart()
        {
            InitializeComponent();
            IDTextBox.Text = newPartID.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //Save Button
        {
            //init
            string name = NameTextBox.Text;
            decimal price;
            int inv;
            int min;
            int max;

            try
            {
                price = decimal.Parse(PriceTextBox.Text);
                inv = int.Parse(InventoryTextBox.Text);
                min = int.Parse(MinTextBox.Text);
                max = int.Parse(MaxTextBox.Text);
            }
            catch 
            {
                MessageBox.Show("Error: Price, Inventory, Min, and Max must be numeric.");
                return;
            }

            price = decimal.Parse(PriceTextBox.Text);
            inv = int.Parse(InventoryTextBox.Text);
            min = int.Parse(MinTextBox.Text);
            max = int.Parse(MaxTextBox.Text);

            //makes sure min is less than max
            if (min > max)
            {
                MessageBox.Show("Min must be less than max.");
                return;
            }

            if (inv > max || inv < min)
            {
                MessageBox.Show("Amount in inventory must be greater than min and less than max.");
                return;
            }

            

            if (inHouseButton.Checked)
            {
                int machID;
                try
                {
                    machID = int.Parse(LastTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Machine ID must be numeric.");
                    return;
                }
                machID = int.Parse(LastTextBox.Text);
                Part newPart = new Inhouse(newPartID, name, price, inv, min, max, machID);
                Inventory.AddPart(newPart);
            }
            else
            {
                string compName = LastTextBox.Text;
                Part newPart = new Outsourced(newPartID, name, price, inv, min, max, compName);
                Inventory.AddPart(newPart);
            }
            Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
