namespace GymMembership
{
    partial class frmGymMembership
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
            this.grpMembership = new System.Windows.Forms.GroupBox();
            this.rdoSenior = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.chkTowelService = new System.Windows.Forms.CheckBox();
            this.chkSpaAccess = new System.Windows.Forms.CheckBox();
            this.chkPrivateLockerRoom = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.grpMembership.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMembership
            // 
            this.grpMembership.Controls.Add(this.rdoSenior);
            this.grpMembership.Controls.Add(this.rdoAdult);
            this.grpMembership.Controls.Add(this.rdoStudent);
            this.grpMembership.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembership.Location = new System.Drawing.Point(36, 31);
            this.grpMembership.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMembership.Name = "grpMembership";
            this.grpMembership.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMembership.Size = new System.Drawing.Size(300, 196);
            this.grpMembership.TabIndex = 0;
            this.grpMembership.TabStop = false;
            this.grpMembership.Text = "Membership";
            // 
            // rdoSenior
            // 
            this.rdoSenior.AutoSize = true;
            this.rdoSenior.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSenior.Location = new System.Drawing.Point(65, 122);
            this.rdoSenior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoSenior.Name = "rdoSenior";
            this.rdoSenior.Size = new System.Drawing.Size(123, 23);
            this.rdoSenior.TabIndex = 2;
            this.rdoSenior.TabStop = true;
            this.rdoSenior.Text = "Senior (65+)";
            this.rdoSenior.UseVisualStyleBackColor = true;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(65, 89);
            this.rdoAdult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(125, 23);
            this.rdoAdult.TabIndex = 1;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adult (18-64)";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStudent.Location = new System.Drawing.Point(65, 55);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(85, 23);
            this.rdoStudent.TabIndex = 0;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.chkTowelService);
            this.grpExtras.Controls.Add(this.chkSpaAccess);
            this.grpExtras.Controls.Add(this.chkPrivateLockerRoom);
            this.grpExtras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExtras.Location = new System.Drawing.Point(364, 31);
            this.grpExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Size = new System.Drawing.Size(328, 196);
            this.grpExtras.TabIndex = 3;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras";
            // 
            // chkTowelService
            // 
            this.chkTowelService.AutoSize = true;
            this.chkTowelService.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTowelService.Location = new System.Drawing.Point(63, 122);
            this.chkTowelService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTowelService.Name = "chkTowelService";
            this.chkTowelService.Size = new System.Drawing.Size(130, 23);
            this.chkTowelService.TabIndex = 2;
            this.chkTowelService.Text = "Towel Service";
            this.chkTowelService.UseVisualStyleBackColor = true;
            // 
            // chkSpaAccess
            // 
            this.chkSpaAccess.AutoSize = true;
            this.chkSpaAccess.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpaAccess.Location = new System.Drawing.Point(63, 90);
            this.chkSpaAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSpaAccess.Name = "chkSpaAccess";
            this.chkSpaAccess.Size = new System.Drawing.Size(118, 23);
            this.chkSpaAccess.TabIndex = 1;
            this.chkSpaAccess.Text = "Spa Access";
            this.chkSpaAccess.UseVisualStyleBackColor = true;
            // 
            // chkPrivateLockerRoom
            // 
            this.chkPrivateLockerRoom.AutoSize = true;
            this.chkPrivateLockerRoom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivateLockerRoom.Location = new System.Drawing.Point(63, 55);
            this.chkPrivateLockerRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPrivateLockerRoom.Name = "chkPrivateLockerRoom";
            this.chkPrivateLockerRoom.Size = new System.Drawing.Size(183, 23);
            this.chkPrivateLockerRoom.TabIndex = 0;
            this.chkPrivateLockerRoom.Text = "Private Locker Room";
            this.chkPrivateLockerRoom.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(700, 31);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(249, 123);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Fee";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFee.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(700, 160);
            this.lblTotalFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(249, 66);
            this.lblTotalFee.TabIndex = 5;
            this.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGymMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 272);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpMembership);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGymMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Membership";
            this.grpMembership.ResumeLayout(false);
            this.grpMembership.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMembership;
        private System.Windows.Forms.RadioButton rdoSenior;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkTowelService;
        private System.Windows.Forms.CheckBox chkSpaAccess;
        private System.Windows.Forms.CheckBox chkPrivateLockerRoom;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalFee;
    }
}

