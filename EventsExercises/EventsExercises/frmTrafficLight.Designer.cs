namespace EventsExercises
{
    partial class frmTrafficLight
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.Red;
            this.txtRed.Location = new System.Drawing.Point(155, 106);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(36, 22);
            this.txtRed.TabIndex = 0;
            this.txtRed.Enter += new System.EventHandler(this.txtRed_Enter);
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(155, 134);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(36, 22);
            this.txtYellow.TabIndex = 1;
            this.txtYellow.Enter += new System.EventHandler(this.txtYellow_Enter);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(155, 162);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(36, 22);
            this.txtGreen.TabIndex = 2;
            this.txtGreen.Enter += new System.EventHandler(this.txtGreen_Enter);
            // 
            // frmTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.txtRed);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrafficLight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrafficLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.TextBox txtGreen;
    }
}