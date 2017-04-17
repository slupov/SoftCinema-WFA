namespace SoftCinema.Client.Forms
{
    partial class TicketTypeForm
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
            this.regularLabel = new System.Windows.Forms.Label();
            this.childrenLabel = new System.Windows.Forms.Label();
            this.seniorsLabel = new System.Windows.Forms.Label();
            this.regularQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.studentsQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.seniorsQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.childrenQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regularLabel
            // 
            this.regularLabel.AutoSize = true;
            this.regularLabel.Location = new System.Drawing.Point(298, 110);
            this.regularLabel.Name = "regularLabel";
            this.regularLabel.Size = new System.Drawing.Size(44, 13);
            this.regularLabel.TabIndex = 0;
            this.regularLabel.Text = "Regular";
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Location = new System.Drawing.Point(298, 157);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(45, 13);
            this.childrenLabel.TabIndex = 1;
            this.childrenLabel.Text = "Children";
            // 
            // seniorsLabel
            // 
            this.seniorsLabel.AutoSize = true;
            this.seniorsLabel.Location = new System.Drawing.Point(298, 201);
            this.seniorsLabel.Name = "seniorsLabel";
            this.seniorsLabel.Size = new System.Drawing.Size(42, 13);
            this.seniorsLabel.TabIndex = 2;
            this.seniorsLabel.Text = "Seniors";
            // 
            // regularQuantityComboBox
            // 
            this.regularQuantityComboBox.FormattingEnabled = true;
            this.regularQuantityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.regularQuantityComboBox.Location = new System.Drawing.Point(408, 110);
            this.regularQuantityComboBox.Name = "regularQuantityComboBox";
            this.regularQuantityComboBox.Size = new System.Drawing.Size(42, 21);
            this.regularQuantityComboBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(404, 77);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(298, 247);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(49, 13);
            this.studentsLabel.TabIndex = 7;
            this.studentsLabel.Text = "Students";
            // 
            // studentsQuantityComboBox
            // 
            this.studentsQuantityComboBox.FormattingEnabled = true;
            this.studentsQuantityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.studentsQuantityComboBox.Location = new System.Drawing.Point(407, 247);
            this.studentsQuantityComboBox.Name = "studentsQuantityComboBox";
            this.studentsQuantityComboBox.Size = new System.Drawing.Size(42, 21);
            this.studentsQuantityComboBox.TabIndex = 8;
            // 
            // seniorsQuantityComboBox
            // 
            this.seniorsQuantityComboBox.FormattingEnabled = true;
            this.seniorsQuantityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.seniorsQuantityComboBox.Location = new System.Drawing.Point(407, 201);
            this.seniorsQuantityComboBox.Name = "seniorsQuantityComboBox";
            this.seniorsQuantityComboBox.Size = new System.Drawing.Size(42, 21);
            this.seniorsQuantityComboBox.TabIndex = 9;
            // 
            // childrenQuantityComboBox
            // 
            this.childrenQuantityComboBox.FormattingEnabled = true;
            this.childrenQuantityComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.childrenQuantityComboBox.Location = new System.Drawing.Point(408, 157);
            this.childrenQuantityComboBox.Name = "childrenQuantityComboBox";
            this.childrenQuantityComboBox.Size = new System.Drawing.Size(42, 21);
            this.childrenQuantityComboBox.TabIndex = 10;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(301, 300);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(125, 42);
            this.purchase.TabIndex = 11;
            this.purchase.Text = "Select Seats";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // TicketTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.childrenQuantityComboBox);
            this.Controls.Add(this.seniorsQuantityComboBox);
            this.Controls.Add(this.studentsQuantityComboBox);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.regularQuantityComboBox);
            this.Controls.Add(this.seniorsLabel);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.regularLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regularLabel;
        private System.Windows.Forms.Label childrenLabel;
        private System.Windows.Forms.Label seniorsLabel;
        private System.Windows.Forms.ComboBox regularQuantityComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.ComboBox studentsQuantityComboBox;
        private System.Windows.Forms.ComboBox seniorsQuantityComboBox;
        private System.Windows.Forms.ComboBox childrenQuantityComboBox;
        private System.Windows.Forms.Button purchase;
    }
}