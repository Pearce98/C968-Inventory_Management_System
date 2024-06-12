namespace PearcePhanawongC968
{
    partial class Form1
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
            AddPart = new Button();
            delPart = new Button();
            addProd = new Button();
            modProd = new Button();
            delProd = new Button();
            button7 = new Button();
            PartSearchButton = new Button();
            ProdSearchButton = new Button();
            label2 = new Label();
            label3 = new Label();
            ProductSearchBar = new TextBox();
            PartSearchBar = new TextBox();
            PartGridView = new DataGridView();
            ProdGridView = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 18;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(218, 359);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(75, 23);
            AddPart.TabIndex = 3;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            AddPart.Click += AddPart_Click;
            // 
            // delPart
            // 
            delPart.Location = new Point(380, 359);
            delPart.Name = "delPart";
            delPart.Size = new Size(75, 23);
            delPart.TabIndex = 5;
            delPart.Text = "Delete";
            delPart.UseVisualStyleBackColor = true;
            delPart.Click += delPart_Click;
            // 
            // addProd
            // 
            addProd.Location = new Point(746, 360);
            addProd.Name = "addProd";
            addProd.Size = new Size(75, 23);
            addProd.TabIndex = 6;
            addProd.Text = "Add";
            addProd.UseVisualStyleBackColor = true;
            addProd.Click += addProd_Click;
            // 
            // modProd
            // 
            modProd.Location = new Point(827, 360);
            modProd.Name = "modProd";
            modProd.Size = new Size(75, 23);
            modProd.TabIndex = 7;
            modProd.Text = "Modify";
            modProd.UseVisualStyleBackColor = true;
            modProd.Click += modProd_Click;
            // 
            // delProd
            // 
            delProd.Location = new Point(908, 360);
            delProd.Name = "delProd";
            delProd.Size = new Size(75, 23);
            delProd.TabIndex = 8;
            delProd.Text = "Delete";
            delProd.UseVisualStyleBackColor = true;
            delProd.Click += delProd_Click;
            // 
            // button7
            // 
            button7.Location = new Point(908, 416);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 9;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // PartSearchButton
            // 
            PartSearchButton.Location = new Point(380, 119);
            PartSearchButton.Name = "PartSearchButton";
            PartSearchButton.Size = new Size(75, 23);
            PartSearchButton.TabIndex = 10;
            PartSearchButton.Text = "Search";
            PartSearchButton.UseVisualStyleBackColor = true;
            PartSearchButton.Click += button8_Click;
            // 
            // ProdSearchButton
            // 
            ProdSearchButton.Location = new Point(908, 120);
            ProdSearchButton.Name = "ProdSearchButton";
            ProdSearchButton.Size = new Size(75, 23);
            ProdSearchButton.TabIndex = 11;
            ProdSearchButton.Text = "Search";
            ProdSearchButton.UseVisualStyleBackColor = true;
            ProdSearchButton.Click += ProdSearchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 12;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(540, 91);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 13;
            label3.Text = "Products";
            // 
            // ProductSearchBar
            // 
            ProductSearchBar.Location = new Point(746, 120);
            ProductSearchBar.Name = "ProductSearchBar";
            ProductSearchBar.Size = new Size(156, 23);
            ProductSearchBar.TabIndex = 14;
            // 
            // PartSearchBar
            // 
            PartSearchBar.Location = new Point(218, 121);
            PartSearchBar.Name = "PartSearchBar";
            PartSearchBar.Size = new Size(156, 23);
            PartSearchBar.TabIndex = 15;
            // 
            // PartGridView
            // 
            PartGridView.AllowUserToAddRows = false;
            PartGridView.AllowUserToDeleteRows = false;
            PartGridView.AllowUserToResizeColumns = false;
            PartGridView.AllowUserToResizeRows = false;
            PartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartGridView.Location = new Point(12, 149);
            PartGridView.MultiSelect = false;
            PartGridView.Name = "PartGridView";
            PartGridView.ReadOnly = true;
            PartGridView.RowHeadersVisible = false;
            PartGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PartGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartGridView.Size = new Size(443, 204);
            PartGridView.TabIndex = 16;
            // 
            // ProdGridView
            // 
            ProdGridView.AccessibleName = "ProdGridView";
            ProdGridView.AllowUserToAddRows = false;
            ProdGridView.AllowUserToDeleteRows = false;
            ProdGridView.AllowUserToResizeColumns = false;
            ProdGridView.AllowUserToResizeRows = false;
            ProdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdGridView.Location = new Point(540, 149);
            ProdGridView.MultiSelect = false;
            ProdGridView.Name = "ProdGridView";
            ProdGridView.ReadOnly = true;
            ProdGridView.RowHeadersVisible = false;
            ProdGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProdGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdGridView.Size = new Size(443, 204);
            ProdGridView.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(718, 10);
            label4.Name = "label4";
            label4.Size = new Size(265, 32);
            label4.TabIndex = 19;
            label4.Text = "Inventory Management";
            // 
            // button1
            // 
            button1.Location = new Point(299, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Modify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(ProdGridView);
            Controls.Add(PartGridView);
            Controls.Add(PartSearchBar);
            Controls.Add(ProductSearchBar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProdSearchButton);
            Controls.Add(PartSearchButton);
            Controls.Add(button7);
            Controls.Add(delProd);
            Controls.Add(modProd);
            Controls.Add(addProd);
            Controls.Add(delPart);
            Controls.Add(AddPart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PartGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddPart;
        private Button delPart;
        private Button addProd;
        private Button modProd;
        private Button delProd;
        private Button button7;
        private Button PartSearchButton;
        private Button ProdSearchButton;
        private Label label2;
        private Label label3;
        private TextBox ProductSearchBar;
        private TextBox PartSearchBar;
        private DataGridView PartGridView;
        private DataGridView ProdGridView;
        private Label label4;
        private Button button1;
    }
}