namespace ForLoopDemo
{
    partial class frmMenu
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
            this.btnPopulation = new System.Windows.Forms.Button();
            this.btnStepDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopulation
            // 
            this.btnPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulation.Location = new System.Drawing.Point(53, 33);
            this.btnPopulation.Name = "btnPopulation";
            this.btnPopulation.Size = new System.Drawing.Size(245, 81);
            this.btnPopulation.TabIndex = 0;
            this.btnPopulation.Text = "Population";
            this.btnPopulation.UseVisualStyleBackColor = true;
            this.btnPopulation.Click += new System.EventHandler(this.btnPopulation_Click);
            // 
            // btnStepDemo
            // 
            this.btnStepDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepDemo.Location = new System.Drawing.Point(53, 120);
            this.btnStepDemo.Name = "btnStepDemo";
            this.btnStepDemo.Size = new System.Drawing.Size(245, 81);
            this.btnStepDemo.TabIndex = 1;
            this.btnStepDemo.Text = "For Loop Step Demo";
            this.btnStepDemo.UseVisualStyleBackColor = true;
            this.btnStepDemo.Click += new System.EventHandler(this.btnStepDemo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 249);
            this.Controls.Add(this.btnStepDemo);
            this.Controls.Add(this.btnPopulation);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For Loop Demo - Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulation;
        private System.Windows.Forms.Button btnStepDemo;
    }
}

