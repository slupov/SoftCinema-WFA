namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    partial class EditScreeningForm
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
            this.CinemaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CinemaLabel
            // 
            this.CinemaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.CinemaLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.CinemaLabel.Location = new System.Drawing.Point(38, 32);
            this.CinemaLabel.Name = "CinemaLabel";
            this.CinemaLabel.Size = new System.Drawing.Size(478, 70);
            this.CinemaLabel.TabIndex = 7;
            this.CinemaLabel.Text = "Edit Screenings";
            // 
            // EditScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1083, 502);
            this.Controls.Add(this.CinemaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditScreeningForm";
            this.Text = "EditScreeningForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CinemaLabel;
    }
}