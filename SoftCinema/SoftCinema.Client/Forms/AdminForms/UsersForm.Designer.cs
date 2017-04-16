namespace SoftCinema.Client.Forms.AdminForms
{
    partial class UsersForm
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
            this.UserList = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UserDetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 38;
            this.UserList.Location = new System.Drawing.Point(153, 85);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(452, 308);
            this.UserList.TabIndex = 0;
            this.UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserList_MouseDoubleClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(153, 414);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(452, 30);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.UserList_Search);
            // 
            // UserDetailsLabel
            // 
            this.UserDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDetailsLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserDetailsLabel.Location = new System.Drawing.Point(146, 27);
            this.UserDetailsLabel.Name = "UserDetailsLabel";
            this.UserDetailsLabel.Size = new System.Drawing.Size(414, 55);
            this.UserDetailsLabel.TabIndex = 4;
            this.UserDetailsLabel.Text = "Select a User to Edit";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1030, 512);
            this.Controls.Add(this.UserDetailsLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label UserDetailsLabel;
    }
}