namespace SoftCinema.Client.Forms.EmployeeForms
{
    partial class ShowScreeningReservationsForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchByUsernameLabel = new System.Windows.Forms.Label();
            this.searchByUsernameTextBox = new System.Windows.Forms.TextBox();
            this.sellAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(36, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // searchByUsernameLabel
            // 
            this.searchByUsernameLabel.AutoSize = true;
            this.searchByUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByUsernameLabel.Location = new System.Drawing.Point(40, 70);
            this.searchByUsernameLabel.Name = "searchByUsernameLabel";
            this.searchByUsernameLabel.Size = new System.Drawing.Size(89, 17);
            this.searchByUsernameLabel.TabIndex = 1;
            this.searchByUsernameLabel.Text = "Search user:";
            // 
            // searchByUsernameTextBox
            // 
            this.searchByUsernameTextBox.Location = new System.Drawing.Point(155, 70);
            this.searchByUsernameTextBox.Name = "searchByUsernameTextBox";
            this.searchByUsernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.searchByUsernameTextBox.TabIndex = 2;
            this.searchByUsernameTextBox.TextChanged += new System.EventHandler(this.searchByUsernameTextBox_TextChanged);
            // 
            // sellAllButton
            // 
            this.sellAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sellAllButton.Location = new System.Drawing.Point(373, 63);
            this.sellAllButton.Name = "sellAllButton";
            this.sellAllButton.Size = new System.Drawing.Size(75, 27);
            this.sellAllButton.TabIndex = 3;
            this.sellAllButton.Text = "Sell all";
            this.sellAllButton.UseVisualStyleBackColor = true;
            this.sellAllButton.Click += new System.EventHandler(this.sellAllButton_Click);
            // 
            // ShowScreeningReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 418);
            this.Controls.Add(this.sellAllButton);
            this.Controls.Add(this.searchByUsernameTextBox);
            this.Controls.Add(this.searchByUsernameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ShowScreeningReservationsForm";
            this.Text = "ShowScreeningReservationsForm";
            this.Load += new System.EventHandler(this.ShowScreeningReservationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label searchByUsernameLabel;
        private System.Windows.Forms.TextBox searchByUsernameTextBox;
        private System.Windows.Forms.Button sellAllButton;
    }
}