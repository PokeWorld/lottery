namespace revolution_demos
{
    partial class launcher
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnUltraBillions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAppTitleDisplay = new System.Windows.Forms.Label();
            this.lblAppDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revolution Demos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "This is an application that contains games and extensions that may or may not be " +
    "put into revolutiongame.";
            // 
            // btnUltraBillions
            // 
            this.btnUltraBillions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltraBillions.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.btnUltraBillions.Location = new System.Drawing.Point(13, 59);
            this.btnUltraBillions.Name = "btnUltraBillions";
            this.btnUltraBillions.Size = new System.Drawing.Size(135, 23);
            this.btnUltraBillions.TabIndex = 2;
            this.btnUltraBillions.Text = "Ultra Billions";
            this.btnUltraBillions.UseVisualStyleBackColor = true;
            this.btnUltraBillions.Click += new System.EventHandler(this.btnUltraBillions_Click);
            this.btnUltraBillions.MouseHover += new System.EventHandler(this.btnUltraBillions_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAppDesc);
            this.panel1.Controls.Add(this.lblAppTitleDisplay);
            this.panel1.Location = new System.Drawing.Point(-1, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 171);
            this.panel1.TabIndex = 3;
            // 
            // lblAppTitleDisplay
            // 
            this.lblAppTitleDisplay.AutoSize = true;
            this.lblAppTitleDisplay.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblAppTitleDisplay.Location = new System.Drawing.Point(14, 4);
            this.lblAppTitleDisplay.Name = "lblAppTitleDisplay";
            this.lblAppTitleDisplay.Size = new System.Drawing.Size(0, 19);
            this.lblAppTitleDisplay.TabIndex = 0;
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.AutoSize = true;
            this.lblAppDesc.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.lblAppDesc.Location = new System.Drawing.Point(13, 36);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(0, 16);
            this.lblAppDesc.TabIndex = 1;
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUltraBillions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "launcher";
            this.Text = "Revolution Demos Launcher";
            this.MouseHover += new System.EventHandler(this.launcher_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUltraBillions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAppTitleDisplay;
        private System.Windows.Forms.Label lblAppDesc;
    }
}