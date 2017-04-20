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
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserList.FormattingEnabled = true;
            this.UserList.HorizontalScrollbar = true;
            this.UserList.ItemHeight = 30;
            this.UserList.Location = new System.Drawing.Point(158, 90);
            this.UserList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserList.Name = "UserList";
            this.UserList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserList.Size = new System.Drawing.Size(412, 184);
            this.UserList.TabIndex = 0;
            this.UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserList_MouseDoubleClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(158, 327);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SearchTextBox.Size = new System.Drawing.Size(412, 26);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.UserList_Search);
            // 
            // UserDetailsLabel
            // 
            this.UserDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.UserDetailsLabel.Location = new System.Drawing.Point(34, 9);
            this.UserDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserDetailsLabel.Name = "UserDetailsLabel";
            this.UserDetailsLabel.Size = new System.Drawing.Size(481, 57);
            this.UserDetailsLabel.TabIndex = 4;
            this.UserDetailsLabel.Text = "Select a User to Edit";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(263, 374);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(190, 31);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back to Admin Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(772, 416);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UserDetailsLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label UserDetailsLabel;
        private System.Windows.Forms.Button BackButton;
    }
}