namespace SoftCinema.Client.Forms.ContentHolders
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
            this.label1 = new System.Windows.Forms.Label();
            this.ticketLimit = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regularLabel
            // 
            this.regularLabel.AutoSize = true;
            this.regularLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regularLabel.ForeColor = System.Drawing.Color.LightGray;
            this.regularLabel.Location = new System.Drawing.Point(210, 121);
            this.regularLabel.Name = "regularLabel";
            this.regularLabel.Size = new System.Drawing.Size(104, 30);
            this.regularLabel.TabIndex = 0;
            this.regularLabel.Text = "Regular";
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.childrenLabel.ForeColor = System.Drawing.Color.LightGray;
            this.childrenLabel.Location = new System.Drawing.Point(210, 171);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(114, 30);
            this.childrenLabel.TabIndex = 1;
            this.childrenLabel.Text = "Children";
            // 
            // seniorsLabel
            // 
            this.seniorsLabel.AutoSize = true;
            this.seniorsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seniorsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.seniorsLabel.Location = new System.Drawing.Point(210, 221);
            this.seniorsLabel.Name = "seniorsLabel";
            this.seniorsLabel.Size = new System.Drawing.Size(95, 30);
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
            this.regularQuantityComboBox.Location = new System.Drawing.Point(403, 130);
            this.regularQuantityComboBox.Name = "regularQuantityComboBox";
            this.regularQuantityComboBox.Size = new System.Drawing.Size(73, 21);
            this.regularQuantityComboBox.TabIndex = 3;
            this.regularQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.regularQuantityComboBox_SelectedIndexChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.ForeColor = System.Drawing.Color.LightGray;
            this.quantityLabel.Location = new System.Drawing.Point(387, 82);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 30);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.studentsLabel.Location = new System.Drawing.Point(210, 271);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(113, 30);
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
            this.studentsQuantityComboBox.Location = new System.Drawing.Point(403, 280);
            this.studentsQuantityComboBox.Name = "studentsQuantityComboBox";
            this.studentsQuantityComboBox.Size = new System.Drawing.Size(73, 21);
            this.studentsQuantityComboBox.TabIndex = 8;
            this.studentsQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.studentsQuantityComboBox_SelectedIndexChanged);
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
            this.seniorsQuantityComboBox.Location = new System.Drawing.Point(403, 230);
            this.seniorsQuantityComboBox.Name = "seniorsQuantityComboBox";
            this.seniorsQuantityComboBox.Size = new System.Drawing.Size(73, 21);
            this.seniorsQuantityComboBox.TabIndex = 9;
            this.seniorsQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.seniorsQuantityComboBox_SelectedIndexChanged);
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
            this.childrenQuantityComboBox.Location = new System.Drawing.Point(403, 180);
            this.childrenQuantityComboBox.Name = "childrenQuantityComboBox";
            this.childrenQuantityComboBox.Size = new System.Drawing.Size(73, 21);
            this.childrenQuantityComboBox.TabIndex = 10;
            this.childrenQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.childrenQuantityComboBox_SelectedIndexChanged);
            // 
            // purchase
            // 
            this.purchase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchase.Location = new System.Drawing.Point(392, 338);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(125, 42);
            this.purchase.TabIndex = 11;
            this.purchase.Text = "Select Seats";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Tickets Type";
            // 
            // ticketLimit
            // 
            this.ticketLimit.AutoSize = true;
            this.ticketLimit.ForeColor = System.Drawing.Color.Red;
            this.ticketLimit.Location = new System.Drawing.Point(400, 322);
            this.ticketLimit.Name = "ticketLimit";
            this.ticketLimit.Size = new System.Drawing.Size(174, 13);
            this.ticketLimit.TabIndex = 13;
            this.ticketLimit.Text = "You can\'t buy more than 10 tickets!";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(215, 338);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 42);
            this.back.TabIndex = 14;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.priceLabel.Location = new System.Drawing.Point(563, 82);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 30);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.LightGray;
            this.price.Location = new System.Drawing.Point(563, 121);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 30);
            this.price.TabIndex = 16;
            // 
            // TicketTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ticketLimit);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.TicketTypeForm_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ticketLimit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label price;
    }
}