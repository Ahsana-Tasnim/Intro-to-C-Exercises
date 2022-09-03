namespace EmployeeBenefitsCheckedChng
{
    partial class frmEmpBenefits
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
            this.chkDrugPlan = new System.Windows.Forms.CheckBox();
            this.chkDental = new System.Windows.Forms.CheckBox();
            this.chkLife = new System.Windows.Forms.CheckBox();
            this.chkLTD = new System.Windows.Forms.CheckBox();
            this.lblMonthlyCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Benefits";
            // 
            // chkDrugPlan
            // 
            this.chkDrugPlan.AutoSize = true;
            this.chkDrugPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrugPlan.Location = new System.Drawing.Point(116, 89);
            this.chkDrugPlan.Margin = new System.Windows.Forms.Padding(4);
            this.chkDrugPlan.Name = "chkDrugPlan";
            this.chkDrugPlan.Size = new System.Drawing.Size(267, 24);
            this.chkDrugPlan.TabIndex = 9;
            this.chkDrugPlan.Text = "Prescription Drug Plan ($45.19)";
            this.chkDrugPlan.UseVisualStyleBackColor = true;
            this.chkDrugPlan.CheckStateChanged += new System.EventHandler(this.chkDrugPlan_CheckStateChanged);
            // 
            // chkDental
            // 
            this.chkDental.AutoSize = true;
            this.chkDental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDental.Location = new System.Drawing.Point(116, 122);
            this.chkDental.Margin = new System.Windows.Forms.Padding(4);
            this.chkDental.Name = "chkDental";
            this.chkDental.Size = new System.Drawing.Size(184, 24);
            this.chkDental.TabIndex = 10;
            this.chkDental.Text = "Dental Plan ($18.21)";
            this.chkDental.UseVisualStyleBackColor = true;
            this.chkDental.CheckStateChanged += new System.EventHandler(this.chkDental_CheckStateChanged);
            // 
            // chkLife
            // 
            this.chkLife.AutoSize = true;
            this.chkLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLife.Location = new System.Drawing.Point(116, 155);
            this.chkLife.Margin = new System.Windows.Forms.Padding(4);
            this.chkLife.Name = "chkLife";
            this.chkLife.Size = new System.Drawing.Size(194, 24);
            this.chkLife.TabIndex = 11;
            this.chkLife.Text = "Life Insurance ($4.32)";
            this.chkLife.UseVisualStyleBackColor = true;
            this.chkLife.CheckStateChanged += new System.EventHandler(this.chkLife_CheckStateChanged);
            // 
            // chkLTD
            // 
            this.chkLTD.AutoSize = true;
            this.chkLTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLTD.Location = new System.Drawing.Point(116, 188);
            this.chkLTD.Margin = new System.Windows.Forms.Padding(4);
            this.chkLTD.Name = "chkLTD";
            this.chkLTD.Size = new System.Drawing.Size(252, 24);
            this.chkLTD.TabIndex = 12;
            this.chkLTD.Text = "Long Term Disability ($12.45)";
            this.chkLTD.UseVisualStyleBackColor = true;
            this.chkLTD.CheckStateChanged += new System.EventHandler(this.chkLTD_CheckStateChanged);
            // 
            // lblMonthlyCost
            // 
            this.lblMonthlyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyCost.Location = new System.Drawing.Point(313, 278);
            this.lblMonthlyCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyCost.Name = "lblMonthlyCost";
            this.lblMonthlyCost.Size = new System.Drawing.Size(133, 28);
            this.lblMonthlyCost.TabIndex = 15;
            this.lblMonthlyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Monthly Cost:";
            // 
            // frmEmpBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 362);
            this.Controls.Add(this.lblMonthlyCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkLTD);
            this.Controls.Add(this.chkLife);
            this.Controls.Add(this.chkDental);
            this.Controls.Add(this.chkDrugPlan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpBenefits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Benefits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDrugPlan;
        private System.Windows.Forms.CheckBox chkDental;
        private System.Windows.Forms.CheckBox chkLife;
        private System.Windows.Forms.CheckBox chkLTD;
        private System.Windows.Forms.Label lblMonthlyCost;
        private System.Windows.Forms.Label label2;
    }
}

