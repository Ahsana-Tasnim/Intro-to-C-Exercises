namespace ListBoxDemo_TimeZones
{
    partial class frmTimeZones
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
            this.lstCities = new System.Windows.Forms.ListBox();
            this.btnTimeZones = new System.Windows.Forms.Button();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 16;
            this.lstCities.Location = new System.Drawing.Point(60, 36);
            this.lstCities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(228, 148);
            this.lstCities.TabIndex = 0;
            // 
            // btnTimeZones
            // 
            this.btnTimeZones.Location = new System.Drawing.Point(60, 192);
            this.btnTimeZones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimeZones.Name = "btnTimeZones";
            this.btnTimeZones.Size = new System.Drawing.Size(229, 43);
            this.btnTimeZones.TabIndex = 1;
            this.btnTimeZones.Text = "Show Time Zone";
            this.btnTimeZones.UseVisualStyleBackColor = true;
            this.btnTimeZones.Click += new System.EventHandler(this.btnTimeZones_Click);
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeZone.Location = new System.Drawing.Point(60, 239);
            this.lblTimeZone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(229, 28);
            this.lblTimeZone.TabIndex = 2;
            // 
            // frmTimeZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 320);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.btnTimeZones);
            this.Controls.Add(this.lstCities);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimeZones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTimeZones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Button btnTimeZones;
        private System.Windows.Forms.Label lblTimeZone;
    }
}

