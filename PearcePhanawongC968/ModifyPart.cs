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
    public partial class ModifyPart : Form
    {

        public ModifyPart(Inhouse modPart)
        {
            InitializeComponent();
            initHelper(modPart);
            BoxLast.Text = modPart.MachineID.ToString();
        }

        public ModifyPart(Outsourced modPart)
        {
            InitializeComponent();
            initHelper(modPart);
            OutSourcedButton.Checked = true;
            BoxLast.Text = modPart.CompName;
        }

        private void initHelper(Part modPart)
        {
            BoxID.Text = modPart.PartID.ToString();
            BoxName.Text = modPart.name;
            BoxInv.Text = modPart.InStock.ToString();
            BoxMax.Text = modPart.max.ToString();
            BoxMin.Text = modPart.min.ToString();
            BoxPrice.Text = modPart.price.ToString();
        }

        private void InhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            LastLabel.Text = "MachineID";
        }

        private void OutSourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            LastLabel.Text = "Company Name";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int newID = Convert.ToInt32(BoxID.Text);
            decimal newPrice;
            int newMin;
            int newMax;
            int newInv;
            String newName = BoxName.Text;
            try
            {
                newPrice = Convert.ToDecimal(BoxPrice.Text);
                newMin = Convert.ToInt32(BoxMin.Text);
                newMax = Convert.ToInt32(BoxMax.Text);
                newInv = Convert.ToInt32(BoxInv.Text);
            }
            catch
            {
                MessageBox.Show("ID, Price, Min, Max, and Inventory need to be numeric.");
                return;
            }
            newPrice = Convert.ToDecimal(BoxPrice.Text);
            newMin = Convert.ToInt32(BoxMin.Text);
            newMax = Convert.ToInt32(BoxMax.Text);
            newInv = Convert.ToInt32(BoxInv.Text);


            if (newMin > newMax)
            {
                MessageBox.Show("Minimum inventory cannot be greater than the max.");
                return;
            }

            if (newInv > newMax || newInv < newMin)
            {
                MessageBox.Show("Stock must be between the minimum and the maximum.");
                return;
            }


            if (OutSourcedButton.Checked)
            {
                String newComp = BoxLast.Text;
                Outsourced updatedPart = new Outsourced(newID, newName, newPrice, newInv, newMin, newMax, newComp);
                Inventory.updatePart(newID, updatedPart);
            }
            else
            {
                int newMach;
                try
                {
                    newMach = Convert.ToInt32(BoxLast.Text);
                }
                catch
                {
                    MessageBox.Show("Machine ID must be numeric.");
                    return;
                }
                newMach = Convert.ToInt32(BoxLast.Text);
                Inhouse updatedPart = new Inhouse(newID, newName, newPrice, newInv, newMin, newMax, newMach);
                Inventory.updatePart(newID, updatedPart);
            }

            Close();
        }
    }
}
