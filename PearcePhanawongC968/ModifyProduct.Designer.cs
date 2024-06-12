namespace PearcePhanawongC968
{
    partial class ModifyProduct
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
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            label9 = new Label();
            label8 = new Label();
            AssociatedPartsGrid = new DataGridView();
            AllPartsGrid = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MinTextBox = new TextBox();
            MaxTextBox = new TextBox();
            IDTextBox = new TextBox();
            SaveButton = new Button();
            Cancel = new Button();
            AddPartButton = new Button();
            DeletePartButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(560, 76);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(182, 23);
            SearchTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(748, 76);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(637, 370);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 43;
            label9.Text = "Parts Associated with this Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(773, 49);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 42;
            label8.Text = "All Parts";
            // 
            // AssociatedPartsGrid
            // 
            AssociatedPartsGrid.AllowUserToAddRows = false;
            AssociatedPartsGrid.AllowUserToDeleteRows = false;
            AssociatedPartsGrid.AllowUserToResizeColumns = false;
            AssociatedPartsGrid.AllowUserToResizeRows = false;
            AssociatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPartsGrid.Location = new Point(458, 388);
            AssociatedPartsGrid.MultiSelect = false;
            AssociatedPartsGrid.Name = "AssociatedPartsGrid";
            AssociatedPartsGrid.RowHeadersVisible = false;
            AssociatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedPartsGrid.Size = new Size(365, 204);
            AssociatedPartsGrid.TabIndex = 41;
            AssociatedPartsGrid.TabStop = false;
            // 
            // AllPartsGrid
            // 
            AllPartsGrid.AllowUserToAddRows = false;
            AllPartsGrid.AllowUserToDeleteRows = false;
            AllPartsGrid.AllowUserToResizeColumns = false;
            AllPartsGrid.AllowUserToResizeRows = false;
            AllPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllPartsGrid.Location = new Point(458, 105);
            AllPartsGrid.MultiSelect = false;
            AllPartsGrid.Name = "AllPartsGrid";
            AllPartsGrid.RowHeadersVisible = false;
            AllPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllPartsGrid.Size = new Size(365, 204);
            AllPartsGrid.TabIndex = 40;
            AllPartsGrid.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 391);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 39;
            label7.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 434);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 38;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 351);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 37;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 306);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 36;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 258);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 35;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 215);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 34;
            label2.Text = "ID";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(173, 255);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(160, 23);
            NameTextBox.TabIndex = 1;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(173, 303);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(160, 23);
            InventoryTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(173, 348);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(160, 23);
            PriceTextBox.TabIndex = 3;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(173, 431);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(160, 23);
            MinTextBox.TabIndex = 5;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(173, 388);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(160, 23);
            MaxTextBox.TabIndex = 4;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(173, 212);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(160, 23);
            IDTextBox.TabIndex = 28;
            IDTextBox.TabStop = false;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(748, 657);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(667, 657);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += CancelButton_Click;
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(748, 315);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(75, 23);
            AddPartButton.TabIndex = 25;
            AddPartButton.TabStop = false;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // DeletePartButton
            // 
            DeletePartButton.Location = new Point(748, 598);
            DeletePartButton.Name = "DeletePartButton";
            DeletePartButton.Size = new Size(75, 23);
            DeletePartButton.TabIndex = 24;
            DeletePartButton.TabStop = false;
            DeletePartButton.Text = "Remove";
            DeletePartButton.UseVisualStyleBackColor = true;
            DeletePartButton.Click += DeletePartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 23;
            label1.Text = "Modify Product";
            // 
            // ModifyProduct
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
            Controls.Add(AddPartButton);
            Controls.Add(DeletePartButton);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)AssociatedPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Button SearchButton;
        private Label label9;
        private Label label8;
        private DataGridView AssociatedPartsGrid;
        private DataGridView AllPartsGrid;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NameTextBox;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox MinTextBox;
        private TextBox MaxTextBox;
        private TextBox IDTextBox;
        private Button SaveButton;
        private Button Cancel;
        private Button AddPartButton;
        private Button DeletePartButton;
        private Label label1;
    }
}