namespace DecisionsExercies3
{
    partial class frmEx2Speed
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
            this.btnCheckSpeed = new System.Windows.Forms.Button();
            this.txtCurrentSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckSpeed
            // 
            this.btnCheckSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSpeed.Location = new System.Drawing.Point(53, 90);
            this.btnCheckSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckSpeed.Name = "btnCheckSpeed";
            this.btnCheckSpeed.Size = new System.Drawing.Size(339, 39);
            this.btnCheckSpeed.TabIndex = 5;
            this.btnCheckSpeed.Text = "Check Speed";
            this.btnCheckSpeed.UseVisualStyleBackColor = true;
            this.btnCheckSpeed.Click += new System.EventHandler(this.btnCheckSpeed_Click);
            // 
            // txtCurrentSpeed
            // 
            this.txtCurrentSpeed.Location = new System.Drawing.Point(259, 58);
            this.txtCurrentSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentSpeed.Name = "txtCurrentSpeed";
            this.txtCurrentSpeed.Size = new System.Drawing.Size(132, 22);
            this.txtCurrentSpeed.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current speed in km/h:";
            // 
            // frmEx2Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 191);
            this.Controls.Add(this.btnCheckSpeed);
            this.Controls.Add(this.txtCurrentSpeed);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEx2Speed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 2 - Speed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSpeed;
        private System.Windows.Forms.TextBox txtCurrentSpeed;
        private System.Windows.Forms.Label label1;
    }
}