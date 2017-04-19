using System.Windows.Forms;

namespace SoftCinema.Client.Forms.ContentHolders
{
    partial class SelectSeatsForm
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
            this.freeSeatsLabel = new System.Windows.Forms.Label();
            this.takenSeatsLabel = new System.Windows.Forms.Label();
            this.chosenSeatsLabel = new System.Windows.Forms.Label();
            this.chosenSeatsLegendButton = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.takenSeatsLegendButton = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.freeSeatsLegendLabel = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.reserveButton = new Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(55, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Please select your seats";
            // 
            // freeSeatsLabel
            // 
            this.freeSeatsLabel.AutoSize = true;
            this.freeSeatsLabel.Location = new System.Drawing.Point(89, 71);
            this.freeSeatsLabel.Name = "freeSeatsLabel";
            this.freeSeatsLabel.Size = new System.Drawing.Size(56, 13);
            this.freeSeatsLabel.TabIndex = 4;
            this.freeSeatsLabel.Text = "Free seats";
            // 
            // takenSeatsLabel
            // 
            this.takenSeatsLabel.AutoSize = true;
            this.takenSeatsLabel.Location = new System.Drawing.Point(199, 71);
            this.takenSeatsLabel.Name = "takenSeatsLabel";
            this.takenSeatsLabel.Size = new System.Drawing.Size(66, 13);
            this.takenSeatsLabel.TabIndex = 8;
            this.takenSeatsLabel.Text = "Taken seats";
            // 
            // chosenSeatsLabel
            // 
            this.chosenSeatsLabel.AutoSize = true;
            this.chosenSeatsLabel.Location = new System.Drawing.Point(321, 71);
            this.chosenSeatsLabel.Name = "chosenSeatsLabel";
            this.chosenSeatsLabel.Size = new System.Drawing.Size(71, 13);
            this.chosenSeatsLabel.TabIndex = 10;
            this.chosenSeatsLabel.Text = "Chosen seats";
            // 
            // chosenSeatsLegendButton
            // 
            this.chosenSeatsLegendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(36)))));
            this.chosenSeatsLegendButton.Enabled = false;
            this.chosenSeatsLegendButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.chosenSeatsLegendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chosenSeatsLegendButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenSeatsLegendButton.ForeColor = System.Drawing.Color.White;
            this.chosenSeatsLegendButton.Location = new System.Drawing.Point(293, 64);
            this.chosenSeatsLegendButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.chosenSeatsLegendButton.MinimumSize = new System.Drawing.Size(15, 15);
            this.chosenSeatsLegendButton.Name = "chosenSeatsLegendButton";
            this.chosenSeatsLegendButton.Number = 0;
            this.chosenSeatsLegendButton.Padding = new System.Windows.Forms.Padding(3);
            this.chosenSeatsLegendButton.Row = 0;
            this.chosenSeatsLegendButton.Size = new System.Drawing.Size(20, 20);
            this.chosenSeatsLegendButton.TabIndex = 9;
            this.chosenSeatsLegendButton.Text = "seatButton4";
            this.chosenSeatsLegendButton.UseVisualStyleBackColor = false;
            // 
            // takenSeatsLegendButton
            // 
            this.takenSeatsLegendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(116)))));
            this.takenSeatsLegendButton.Enabled = false;
            this.takenSeatsLegendButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.takenSeatsLegendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takenSeatsLegendButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenSeatsLegendButton.ForeColor = System.Drawing.Color.White;
            this.takenSeatsLegendButton.Location = new System.Drawing.Point(171, 64);
            this.takenSeatsLegendButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.takenSeatsLegendButton.MinimumSize = new System.Drawing.Size(15, 15);
            this.takenSeatsLegendButton.Name = "takenSeatsLegendButton";
            this.takenSeatsLegendButton.Number = 0;
            this.takenSeatsLegendButton.Padding = new System.Windows.Forms.Padding(3);
            this.takenSeatsLegendButton.Row = 0;
            this.takenSeatsLegendButton.Size = new System.Drawing.Size(20, 20);
            this.takenSeatsLegendButton.TabIndex = 7;
            this.takenSeatsLegendButton.Text = "0";
            this.takenSeatsLegendButton.UseVisualStyleBackColor = false;
            // 
            // freeSeatsLegendLabel
            // 
            this.freeSeatsLegendLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.freeSeatsLegendLabel.Enabled = false;
            this.freeSeatsLegendLabel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.freeSeatsLegendLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeSeatsLegendLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSeatsLegendLabel.ForeColor = System.Drawing.Color.White;
            this.freeSeatsLegendLabel.Location = new System.Drawing.Point(61, 64);
            this.freeSeatsLegendLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.freeSeatsLegendLabel.MinimumSize = new System.Drawing.Size(15, 15);
            this.freeSeatsLegendLabel.Name = "freeSeatsLegendLabel";
            this.freeSeatsLegendLabel.Number = 0;
            this.freeSeatsLegendLabel.Padding = new System.Windows.Forms.Padding(3);
            this.freeSeatsLegendLabel.Row = 0;
            this.freeSeatsLegendLabel.Size = new System.Drawing.Size(20, 20);
            this.freeSeatsLegendLabel.TabIndex = 0;
            this.freeSeatsLegendLabel.Text = "seatButton1";
            this.freeSeatsLegendLabel.UseVisualStyleBackColor = false;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Silver;
            this.reserveButton.Enabled = false;
            this.reserveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.reserveButton.Location = new System.Drawing.Point(567, 32);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reserveButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Padding = new System.Windows.Forms.Padding(3);
            this.reserveButton.Size = new System.Drawing.Size(149, 52);
            this.reserveButton.TabIndex = 11;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            this.reserveButton.MouseEnter+=new System.EventHandler(this.reserveButton_Enter);
            this.reserveButton.MouseLeave += new System.EventHandler(this.reserveButton_MouseLeave);
            // 
            // SelectSeatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.chosenSeatsLabel);
            this.Controls.Add(this.chosenSeatsLegendButton);
            this.Controls.Add(this.takenSeatsLabel);
            this.Controls.Add(this.takenSeatsLegendButton);
            this.Controls.Add(this.freeSeatsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.freeSeatsLegendLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectSeatsForm";
            this.Text = "SelectSeatsForm";
            this.Load += new System.EventHandler(this.SelectSeatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilities.CustomTools.SeatButton freeSeatsLegendLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label freeSeatsLabel;
        private System.Windows.Forms.Label takenSeatsLabel;
        private Utilities.CustomTools.SeatButton takenSeatsLegendButton;
        private System.Windows.Forms.Label chosenSeatsLabel;
        private Utilities.CustomTools.SeatButton chosenSeatsLegendButton;
        public Button reserveButton;
    }
}