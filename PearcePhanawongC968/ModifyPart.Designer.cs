namespace PearcePhanawongC968
{
    partial class ModifyPart
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
            BoxLast = new TextBox();
            BoxMin = new TextBox();
            BoxMax = new TextBox();
            BoxPrice = new TextBox();
            BoxInv = new TextBox();
            LastLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BoxID = new TextBox();
            Cancel = new Button();
            SaveButton = new Button();
            OutSourcedButton = new RadioButton();
            InhouseButton = new RadioButton();
            SuspendLayout();
            // 
            // BoxLast
            // 
            BoxLast.Location = new Point(119, 327);
            BoxLast.Name = "BoxLast";
            BoxLast.Size = new Size(100, 23);
            BoxLast.TabIndex = 37;
            // 
            // BoxMin
            // 
            BoxMin.Location = new Point(119, 287);
            BoxMin.Name = "BoxMin";
            BoxMin.Size = new Size(100, 23);
            BoxMin.TabIndex = 36;
            // 
            // BoxMax
            // 
            BoxMax.Location = new Point(119, 247);
            BoxMax.Name = "BoxMax";
            BoxMax.Size = new Size(100, 23);
            BoxMax.TabIndex = 35;
            // 
            // BoxPrice
            // 
            BoxPrice.Location = new Point(119, 209);
            BoxPrice.Name = "BoxPrice";
            BoxPrice.Size = new Size(100, 23);
            BoxPrice.TabIndex = 34;
            // 
            // BoxInv
            // 
            BoxInv.Location = new Point(119, 169);
            BoxInv.Name = "BoxInv";
            BoxInv.Size = new Size(100, 23);
            BoxInv.TabIndex = 33;
            // 
            // LastLabel
            // 
            LastLabel.AutoSize = true;
            LastLabel.Location = new Point(12, 330);
            LastLabel.Name = "LastLabel";
            LastLabel.Size = new Size(94, 15);
            LastLabel.TabIndex = 32;
            LastLabel.Text = "Company Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 290);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 31;
            label7.Text = "Min Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 250);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 30;
            label6.Text = "Max Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 212);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 29;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 172);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 28;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 133);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 27;
            label3.Text = "Name";
            // 
            // BoxName
            // 
            BoxName.Location = new Point(119, 130);
            BoxName.Name = "BoxName";
            BoxName.Size = new Size(100, 23);
            BoxName.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 25;
            label2.Text = "Modify Part";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 97);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 24;
            label1.Text = "ID";
            // 
            // BoxID
            // 
            BoxID.Enabled = false;
            BoxID.Location = new Point(119, 94);
            BoxID.Name = "BoxID";
            BoxID.Size = new Size(100, 23);
            BoxID.TabIndex = 23;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(95, 417);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 22;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(176, 417);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // OutSourcedButton
            // 
            OutSourcedButton.AutoSize = true;
            OutSourcedButton.Location = new Point(119, 55);
            OutSourcedButton.Name = "OutSourcedButton";
            OutSourcedButton.Size = new Size(87, 19);
            OutSourcedButton.TabIndex = 20;
            OutSourcedButton.TabStop = true;
            OutSourcedButton.Text = "Outsourced";
            OutSourcedButton.UseVisualStyleBackColor = true;
            OutSourcedButton.CheckedChanged += OutSourcedButton_CheckedChanged;
            // 
            // InhouseButton
            // 
            InhouseButton.AutoSize = true;
            InhouseButton.Location = new Point(32, 55);
            InhouseButton.Name = "InhouseButton";
            InhouseButton.Size = new Size(74, 19);
            InhouseButton.TabIndex = 19;
            InhouseButton.TabStop = true;
            InhouseButton.Text = "In-House";
            InhouseButton.UseVisualStyleBackColor = true;
            InhouseButton.CheckedChanged += InhouseButton_CheckedChanged;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 450);
            Controls.Add(BoxLast);
            Controls.Add(BoxMin);
            Controls.Add(BoxMax);
            Controls.Add(BoxPrice);
            Controls.Add(BoxInv);
            Controls.Add(LastLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BoxID);
            Controls.Add(Cancel);
            Controls.Add(SaveButton);
            Controls.Add(OutSourcedButton);
            Controls.Add(InhouseButton);
            Name = "ModifyPart";
            Text = "ModifyPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxLast;
        private TextBox BoxMin;
        private TextBox BoxMax;
        private TextBox BoxPrice;
        private TextBox BoxInv;
        private Label LastLabel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox BoxName;
        private Label label2;
        private Label label1;
        private TextBox BoxID;
        private Button Cancel;
        private Button SaveButton;
        private RadioButton OutSourcedButton;
        private RadioButton InhouseButton;
    }
}