namespace SoftCinema.Client.Forms
{
    partial class TopPanelForm
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
            LogoutButton = new System.Windows.Forms.Button();
            GreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new System.Drawing.Point(628, 40);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new System.Drawing.Size(75, 23);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Visible = false;
            LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // GreetingLabel
            // 
            GreetingLabel.AutoSize = true;
            GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GreetingLabel.Location = new System.Drawing.Point(639, 22);
            GreetingLabel.Name = "GreetingLabel";
            GreetingLabel.Size = new System.Drawing.Size(51, 16);
            GreetingLabel.TabIndex = 5;
            GreetingLabel.Text = "label1";
            GreetingLabel.Visible = false;
            // 
            // TopPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 73);
            this.Controls.Add(LogoutButton);
            this.Controls.Add(GreetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopPanelForm";
            this.Text = "TopPanelForm";
            this.Load += new System.EventHandler(this.TopPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.Button LogoutButton;
        private static System.Windows.Forms.Label GreetingLabel;
    }
}