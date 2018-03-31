namespace revolution_demos
{
    partial class qwick_antiwirus
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRunScan = new System.Windows.Forms.Button();
            this.lblwiruses = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Qwick Antiwirus";
            // 
            // btnRunScan
            // 
            this.btnRunScan.Location = new System.Drawing.Point(63, 61);
            this.btnRunScan.Name = "btnRunScan";
            this.btnRunScan.Size = new System.Drawing.Size(110, 23);
            this.btnRunScan.TabIndex = 1;
            this.btnRunScan.Text = "Toggle Wirus Scan";
            this.btnRunScan.UseVisualStyleBackColor = true;
            this.btnRunScan.Click += new System.EventHandler(this.btnRunScan_Click);
            // 
            // lblwiruses
            // 
            this.lblwiruses.AutoSize = true;
            this.lblwiruses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblwiruses.Location = new System.Drawing.Point(15, 125);
            this.lblwiruses.Name = "lblwiruses";
            this.lblwiruses.Size = new System.Drawing.Size(205, 22);
            this.lblwiruses.TabIndex = 2;
            this.lblwiruses.Text = "0 Wiruses Found So Far";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 10;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // qwick_antiwirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 180);
            this.Controls.Add(this.lblwiruses);
            this.Controls.Add(this.btnRunScan);
            this.Controls.Add(this.lblTitle);
            this.Name = "qwick_antiwirus";
            this.Text = "Qwick Antiwirus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRunScan;
        private System.Windows.Forms.Label lblwiruses;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}