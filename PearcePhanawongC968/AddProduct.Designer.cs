namespace PearcePhanawongC968
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DeletePartFromProductButton = new Button();
            AddPartToProductButton = new Button();
            Cancel = new Button();
            SaveButton = new Button();
            IDTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            PriceTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            NameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AllPartsGrid = new DataGridView();
            AssociatedPartsGrid = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AllPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // DeletePartFromProductButton
            // 
            DeletePartFromProductButton.Location = new Point(748, 597);
            DeletePartFromProductButton.Name = "DeletePartFromProductButton";
            DeletePartFromProductButton.Size = new Size(75, 23);
            DeletePartFromProductButton.TabIndex = 1;
            DeletePartFromProductButton.TabStop = false;
            DeletePartFromProductButton.Text = "Remove";
            DeletePartFromProductButton.UseVisualStyleBackColor = true;
            DeletePartFromProductButton.Click += DeletePartFromProductButton_Click;
            // 
            // AddPartToProductButton
            // 
            AddPartToProductButton.Location = new Point(748, 314);
            AddPartToProductButton.Name = "AddPartToProductButton";
            AddPartToProductButton.Size = new Size(75, 23);
            AddPartToProductButton.TabIndex = 2;
            AddPartToProductButton.TabStop = false;
            AddPartToProductButton.Text = "Add";
            AddPartToProductButton.UseVisualStyleBackColor = true;
            AddPartToProductButton.Click += AddPartToProductButton_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(667, 656);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(748, 656);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(173, 211);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(160, 23);
            IDTextBox.TabIndex = 9;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(173, 387);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(160, 23);
            MaxTextBox.TabIndex = 4;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(173, 433);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(160, 23);
            MinTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(173, 347);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(160, 23);
            PriceTextBox.TabIndex = 3;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(173, 302);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(160, 23);
            InventoryTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(173, 254);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(160, 23);
            NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 214);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 257);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 305);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 350);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 14;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 436);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 15;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 390);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "Max";
            // 
            // AllPartsGrid
            // 
            AllPartsGrid.AllowUserToAddRows = false;
            AllPartsGrid.AllowUserToDeleteRows = false;
            AllPartsGrid.AllowUserToResizeColumns = false;
            AllPartsGrid.AllowUserToResizeRows = false;
            AllPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllPartsGrid.Location = new Point(380, 104);
            AllPartsGrid.MultiSelect = false;
            AllPartsGrid.Name = "AllPartsGrid";
            AllPartsGrid.ReadOnly = true;
            AllPartsGrid.RowHeadersVisible = false;
            AllPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllPartsGrid.Size = new Size(443, 204);
            AllPartsGrid.TabIndex = 17;
            AllPartsGrid.TabStop = false;
            // 
            // AssociatedPartsGrid
            // 
            AssociatedPartsGrid.AllowUserToAddRows = false;
            AssociatedPartsGrid.AllowUserToDeleteRows = false;
            AssociatedPartsGrid.AllowUserToResizeColumns = false;
            AssociatedPartsGrid.AllowUserToResizeRows = false;
            AssociatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPartsGrid.Location = new Point(380, 387);
            AssociatedPartsGrid.MultiSelect = false;
            AssociatedPartsGrid.Name = "AssociatedPartsGrid";
            AssociatedPartsGrid.ReadOnly = true;
            AssociatedPartsGrid.RowHeadersVisible = false;
            AssociatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedPartsGrid.Size = new Size(443, 204);
            AssociatedPartsGrid.TabIndex = 18;
            AssociatedPartsGrid.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(773, 48);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 19;
            label8.Text = "All Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(637, 369);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 20;
            label9.Text = "Parts Associated with this Product";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(748, 75);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 21;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(560, 75);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(182, 23);
            SearchTextBox.TabIndex = 8;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 691);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AssociatedPartsGrid);
            Controls.Add(AllPartsGrid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(SaveButton);
            Controls.Add(Cancel);
            Controls.Add(AddPartToProductButton);
            Controls.Add(DeletePartFromProductButton);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)AllPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button DeletePartFromProductButton;
        private Button AddPartToProductButton;
        private Button Cancel;
        private Button SaveButton;
        private TextBox IDTextBox;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private TextBox PriceTextBox;
        private TextBox InventoryTextBox;
        private TextBox NameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView AllPartsGrid;
        private DataGridView AssociatedPartsGrid;
        private Label label8;
        private Label label9;
        private Button SearchButton;
        private TextBox SearchTextBox;
    }
}