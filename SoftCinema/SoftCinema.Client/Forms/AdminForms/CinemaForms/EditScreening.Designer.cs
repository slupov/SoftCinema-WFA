namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    partial class EditScreening
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
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.EditScreeningLabel = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditScreeningButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ScreeningTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateCalendar
            // 
            this.DateCalendar.Location = new System.Drawing.Point(396, 115);
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 0;
            this.DateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateChanged);
            // 
            // EditScreeningLabel
            // 
            this.EditScreeningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.EditScreeningLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditScreeningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.EditScreeningLabel.Location = new System.Drawing.Point(105, 9);
            this.EditScreeningLabel.Name = "EditScreeningLabel";
            this.EditScreeningLabel.Size = new System.Drawing.Size(856, 70);
            this.EditScreeningLabel.TabIndex = 8;
            this.EditScreeningLabel.Text = "Edit Screening";
            this.EditScreeningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(396, 351);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(297, 56);
            this.TimePicker.TabIndex = 9;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // EditScreeningButton
            // 
            this.EditScreeningButton.Location = new System.Drawing.Point(541, 440);
            this.EditScreeningButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditScreeningButton.Name = "EditScreeningButton";
            this.EditScreeningButton.Size = new System.Drawing.Size(152, 46);
            this.EditScreeningButton.TabIndex = 34;
            this.EditScreeningButton.Text = "Save Changes";
            this.EditScreeningButton.UseVisualStyleBackColor = true;
            this.EditScreeningButton.Click += new System.EventHandler(this.EditScreeningButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.Location = new System.Drawing.Point(396, 440);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 46);
            this.BackButton.TabIndex = 33;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ScreeningTaken
            // 
            this.ScreeningTaken.AutoSize = true;
            this.ScreeningTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScreeningTaken.ForeColor = System.Drawing.Color.Red;
            this.ScreeningTaken.Location = new System.Drawing.Point(391, 323);
            this.ScreeningTaken.Name = "ScreeningTaken";
            this.ScreeningTaken.Size = new System.Drawing.Size(248, 25);
            this.ScreeningTaken.TabIndex = 35;
            this.ScreeningTaken.Text = "Screening is already taken!";
            // 
            // EditScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1065, 511);
            this.Controls.Add(this.ScreeningTaken);
            this.Controls.Add(this.EditScreeningButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.EditScreeningLabel);
            this.Controls.Add(this.DateCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditScreening";
            this.Text = "EditScreening";
            this.Load += new System.EventHandler(this.EditScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar DateCalendar;
        private System.Windows.Forms.Label EditScreeningLabel;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button EditScreeningButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ScreeningTaken;
    }
}