namespace EventsExercises
{
    partial class frmFace
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
            this.lblHappy = new System.Windows.Forms.Label();
            this.lblFace = new System.Windows.Forms.Label();
            this.lblSad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHappy
            // 
            this.lblHappy.AutoSize = true;
            this.lblHappy.Location = new System.Drawing.Point(156, 62);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(49, 17);
            this.lblHappy.TabIndex = 0;
            this.lblHappy.Text = "Happy";
            this.lblHappy.MouseEnter += new System.EventHandler(this.lblHappy_MouseEnter);
            this.lblHappy.MouseLeave += new System.EventHandler(this.lblHappy_MouseLeave);
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblFace.Location = new System.Drawing.Point(156, 138);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(0, 15);
            this.lblFace.TabIndex = 1;
            // 
            // lblSad
            // 
            this.lblSad.AutoSize = true;
            this.lblSad.Location = new System.Drawing.Point(156, 224);
            this.lblSad.Name = "lblSad";
            this.lblSad.Size = new System.Drawing.Size(33, 17);
            this.lblSad.TabIndex = 2;
            this.lblSad.Text = "Sad";
            this.lblSad.MouseEnter += new System.EventHandler(this.lblSad_MouseEnter);
            this.lblSad.MouseLeave += new System.EventHandler(this.lblSad_MouseLeave);
            // 
            // frmFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblSad);
            this.Controls.Add(this.lblFace);
            this.Controls.Add(this.lblHappy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHappy;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.Label lblSad;
    }
}