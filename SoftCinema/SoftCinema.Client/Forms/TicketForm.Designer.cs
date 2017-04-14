namespace SoftCinema.Client.Forms
{
    partial class TicketForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.screeningLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.seatLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.townLabel = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.AutoSize = true;
            this.cinemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cinemaLabel.Location = new System.Drawing.Point(144, 92);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(63, 18);
            this.cinemaLabel.TabIndex = 1;
            this.cinemaLabel.Text = "Cinema:";
            this.cinemaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // screeningLabel
            // 
            this.screeningLabel.AutoSize = true;
            this.screeningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.screeningLabel.Location = new System.Drawing.Point(144, 194);
            this.screeningLabel.Name = "screeningLabel";
            this.screeningLabel.Size = new System.Drawing.Size(78, 18);
            this.screeningLabel.TabIndex = 2;
            this.screeningLabel.Text = "Screening:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(255, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateLabel.Location = new System.Drawing.Point(144, 146);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 18);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(255, 146);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.seatLabel.Location = new System.Drawing.Point(144, 246);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(42, 18);
            this.seatLabel.TabIndex = 6;
            this.seatLabel.Text = "Seat:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.totalPriceLabel.Location = new System.Drawing.Point(144, 300);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(79, 17);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Total price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(338, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "BGN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "// TODO: Visualize the audithorium schema with its seats";
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.townLabel.Location = new System.Drawing.Point(144, 36);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(49, 18);
            this.townLabel.TabIndex = 6;
            this.townLabel.Text = "Town:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(255, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 398);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.screeningLabel);
            this.Controls.Add(this.cinemaLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.Label screeningLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}