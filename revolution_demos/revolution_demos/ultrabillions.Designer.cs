namespace revolution_demos
{
    partial class ultrabillions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblYourNumbers = new System.Windows.Forms.Label();
            this.btnGenNewPlayerNumber = new System.Windows.Forms.Button();
            this.lblWinningNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ultra Billions";
            // 
            // lblYourNumbers
            // 
            this.lblYourNumbers.AutoSize = true;
            this.lblYourNumbers.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lblYourNumbers.Location = new System.Drawing.Point(12, 54);
            this.lblYourNumbers.Name = "lblYourNumbers";
            this.lblYourNumbers.Size = new System.Drawing.Size(177, 20);
            this.lblYourNumbers.TabIndex = 1;
            this.lblYourNumbers.Text = "Your Numbers: ";
            // 
            // btnGenNewPlayerNumber
            // 
            this.btnGenNewPlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenNewPlayerNumber.Location = new System.Drawing.Point(531, 9);
            this.btnGenNewPlayerNumber.Name = "btnGenNewPlayerNumber";
            this.btnGenNewPlayerNumber.Size = new System.Drawing.Size(127, 23);
            this.btnGenNewPlayerNumber.TabIndex = 2;
            this.btnGenNewPlayerNumber.Text = "Generate Numbers";
            this.btnGenNewPlayerNumber.UseVisualStyleBackColor = true;
            this.btnGenNewPlayerNumber.Click += new System.EventHandler(this.btnGenNewPlayerNumber_Click);
            // 
            // lblWinningNumbers
            // 
            this.lblWinningNumbers.AutoSize = true;
            this.lblWinningNumbers.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lblWinningNumbers.Location = new System.Drawing.Point(12, 110);
            this.lblWinningNumbers.Name = "lblWinningNumbers";
            this.lblWinningNumbers.Size = new System.Drawing.Size(213, 20);
            this.lblWinningNumbers.TabIndex = 3;
            this.lblWinningNumbers.Text = "Winning Numbers: ";
            // 
            // ultrabillions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 149);
            this.Controls.Add(this.lblWinningNumbers);
            this.Controls.Add(this.btnGenNewPlayerNumber);
            this.Controls.Add(this.lblYourNumbers);
            this.Controls.Add(this.label1);
            this.Name = "ultrabillions";
            this.Text = "Ultra Billions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYourNumbers;
        private System.Windows.Forms.Button btnGenNewPlayerNumber;
        private System.Windows.Forms.Label lblWinningNumbers;
    }
}

