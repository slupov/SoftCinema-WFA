namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    partial class AddScreeningForm
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
            this.EditScreeningLabel = new System.Windows.Forms.Label();
            this.EditScreeningButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.auditoriumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScreeningTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditScreeningLabel
            // 
            this.EditScreeningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.EditScreeningLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditScreeningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.EditScreeningLabel.Location = new System.Drawing.Point(105, 9);
            this.EditScreeningLabel.Name = "EditScreeningLabel";
            this.EditScreeningLabel.Size = new System.Drawing.Size(856, 70);
            this.EditScreeningLabel.TabIndex = 9;
            this.EditScreeningLabel.Text = "Add Screening";
            this.EditScreeningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditScreeningButton
            // 
            this.EditScreeningButton.Location = new System.Drawing.Point(508, 434);
            this.EditScreeningButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditScreeningButton.Name = "EditScreeningButton";
            this.EditScreeningButton.Size = new System.Drawing.Size(152, 46);
            this.EditScreeningButton.TabIndex = 38;
            this.EditScreeningButton.Text = "Create Screening";
            this.EditScreeningButton.UseVisualStyleBackColor = true;
            this.EditScreeningButton.Click += new System.EventHandler(this.AddScreeningButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.Location = new System.Drawing.Point(375, 434);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 46);
            this.BackButton.TabIndex = 37;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(570, 353);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(297, 56);
            this.TimePicker.TabIndex = 36;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // DateCalendar
            // 
            this.DateCalendar.Location = new System.Drawing.Point(570, 114);
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 35;
            this.DateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateChanged);
            // 
            // movieComboBox
            // 
            this.movieComboBox.DisplayMember = "Name";
            this.movieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(228, 183);
            this.movieComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(304, 32);
            this.movieComboBox.TabIndex = 39;
            this.movieComboBox.SelectedIndexChanged += new System.EventHandler(this.movieComboBox_SelectedIndexChanged);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieLabel.ForeColor = System.Drawing.Color.LightGray;
            this.movieLabel.Location = new System.Drawing.Point(93, 183);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(106, 33);
            this.movieLabel.TabIndex = 40;
            this.movieLabel.Text = "Movie:";
            // 
            // auditoriumComboBox
            // 
            this.auditoriumComboBox.DisplayMember = "Name";
            this.auditoriumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auditoriumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auditoriumComboBox.FormattingEnabled = true;
            this.auditoriumComboBox.Location = new System.Drawing.Point(228, 253);
            this.auditoriumComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.auditoriumComboBox.Name = "auditoriumComboBox";
            this.auditoriumComboBox.Size = new System.Drawing.Size(304, 32);
            this.auditoriumComboBox.TabIndex = 42;
            this.auditoriumComboBox.SelectedIndexChanged += new System.EventHandler(this.auditoriumComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(33, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Auditorium:";
            // 
            // ScreeningTaken
            // 
            this.ScreeningTaken.AutoSize = true;
            this.ScreeningTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScreeningTaken.ForeColor = System.Drawing.Color.Red;
            this.ScreeningTaken.Location = new System.Drawing.Point(574, 325);
            this.ScreeningTaken.Name = "ScreeningTaken";
            this.ScreeningTaken.Size = new System.Drawing.Size(248, 25);
            this.ScreeningTaken.TabIndex = 44;
            this.ScreeningTaken.Text = "Screening is already taken!";
            // 
            // AddScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1083, 525);
            this.Controls.Add(this.ScreeningTaken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.auditoriumComboBox);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.EditScreeningButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DateCalendar);
            this.Controls.Add(this.EditScreeningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddScreeningForm";
            this.Text = "AddScreeningForm";
            this.Load += new System.EventHandler(this.AddScreeningForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditScreeningLabel;
        private System.Windows.Forms.Button EditScreeningButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.MonthCalendar DateCalendar;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ComboBox auditoriumComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScreeningTaken;
    }
}