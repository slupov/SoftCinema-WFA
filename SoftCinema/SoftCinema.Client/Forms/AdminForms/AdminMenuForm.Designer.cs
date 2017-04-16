namespace SoftCinema.Client.Forms.AdminForms
{
    partial class AdminMenuForm
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
            this.Menu = new System.Windows.Forms.ListBox();
            this.AdminMenuLabel = new System.Windows.Forms.Label();
            this.UserEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.FormattingEnabled = true;
            this.Menu.ItemHeight = 16;
            this.Menu.Location = new System.Drawing.Point(283, 53);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(355, 372);
            this.Menu.TabIndex = 0;
            // 
            // AdminMenuLabel
            // 
            this.AdminMenuLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AdminMenuLabel.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminMenuLabel.Location = new System.Drawing.Point(368, 74);
            this.AdminMenuLabel.Name = "AdminMenuLabel";
            this.AdminMenuLabel.Size = new System.Drawing.Size(165, 59);
            this.AdminMenuLabel.TabIndex = 1;
            this.AdminMenuLabel.Text = "Menu";
            this.AdminMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserEditButton
            // 
            this.UserEditButton.BackColor = System.Drawing.SystemColors.Menu;
            this.UserEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEditButton.Location = new System.Drawing.Point(348, 162);
            this.UserEditButton.Name = "UserEditButton";
            this.UserEditButton.Size = new System.Drawing.Size(199, 58);
            this.UserEditButton.TabIndex = 2;
            this.UserEditButton.Text = "Edit Users";
            this.UserEditButton.UseVisualStyleBackColor = false;
            this.UserEditButton.Click += new System.EventHandler(this.UserEditButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1041, 512);
            this.Controls.Add(this.UserEditButton);
            this.Controls.Add(this.AdminMenuLabel);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.ListBox Menu;
        private System.Windows.Forms.Label AdminMenuLabel;
        private System.Windows.Forms.Button UserEditButton;
    }
}