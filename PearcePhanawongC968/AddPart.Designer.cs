namespace PearcePhanawongC968
{
    partial class AddPart
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
            inHouseButton = new RadioButton();
            OutsourceButton = new RadioButton();
            SaveButton = new Button();
            Cancel = new Button();
            IDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            MaxTextBox = new TextBox();
            MinTextBox = new TextBox();
            LastTextBox = new TextBox();
            SuspendLayout();
            // 
            // inHouseButton
            // 
            inHouseButton.AutoSize = true;
            inHouseButton.Location = new Point(31, 53);
            inHouseButton.Name = "inHouseButton";
            inHouseButton.Size = new Size(74, 19);
            inHouseButton.TabIndex = 0;
            inHouseButton.TabStop = true;
            inHouseButton.Text = "In-House";
            inHouseButton.UseVisualStyleBackColor = true;
            inHouseButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // OutsourceButton
            // 
            OutsourceButton.AutoSize = true;
            OutsourceButton.Location = new Point(118, 53);
            OutsourceButton.Name = "OutsourceButton";
            OutsourceButton.Size = new Size(87, 19);
            OutsourceButton.TabIndex = 1;
            OutsourceButton.TabStop = true;
            OutsourceButton.Text = "Outsourced";
            OutsourceButton.UseVisualStyleBackColor = true;
            OutsourceButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(175, 415);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(94, 415);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += CancelButton_Click;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(118, 92);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 95);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 6;
            label2.Text = "Add Part";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(118, 128);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 131);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 170);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 210);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 248);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Max Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 288);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 12;
            label7.Text = "Min Value";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(11, 328);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 13;
            label8.Text = "Company Name";
            label8.TextAlign = ContentAlignment.MiddleRight;
            label8.UseMnemonic = false;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(118, 167);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(100, 23);
            InventoryTextBox.TabIndex = 14;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(118, 207);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 15;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(118, 245);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(100, 23);
            MaxTextBox.TabIndex = 16;
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(118, 285);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(100, 23);
            MinTextBox.TabIndex = 17;
            // 
            // LastTextBox
            // 
            LastTextBox.Location = new Point(118, 325);
            LastTextBox.Name = "LastTextBox";
            LastTextBox.Size = new Size(100, 23);
            LastTextBox.TabIndex = 18;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 450);
            Controls.Add(LastTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(MaxTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IDTextBox);
            Controls.Add(Cancel);
            Controls.Add(SaveButton);
            Controls.Add(OutsourceButton);
            Controls.Add(inHouseButton);
            Name = "AddPart";
            Text = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton inHouseButton;
        private RadioButton OutsourceButton;
        private Button SaveButton;
        private Button Cancel;
        private TextBox IDTextBox;
        private Label label1;
        private Label label2;
        private TextBox NameTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox MaxTextBox;
        private TextBox MinTextBox;
        private TextBox LastTextBox;
    }
}