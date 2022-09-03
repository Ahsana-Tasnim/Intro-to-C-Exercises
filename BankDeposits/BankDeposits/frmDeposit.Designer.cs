namespace BankDeposits
{
    partial class frmDeposit
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
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.grpDepositInfo = new System.Windows.Forms.GroupBox();
            this.txtNumChecks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeDeposit = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.lblDepositSummary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalDisplay = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            this.grpDepositInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(413, 64);
            this.txtAccountHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(392, 22);
            this.txtAccountHolder.TabIndex = 1;
            // 
            // grpDepositInfo
            // 
            this.grpDepositInfo.Controls.Add(this.txtNumChecks);
            this.grpDepositInfo.Controls.Add(this.label5);
            this.grpDepositInfo.Controls.Add(this.txtCheckAmt);
            this.grpDepositInfo.Controls.Add(this.label4);
            this.grpDepositInfo.Controls.Add(this.txtCashAmt);
            this.grpDepositInfo.Controls.Add(this.label3);
            this.grpDepositInfo.Controls.Add(this.txtAccountNumber);
            this.grpDepositInfo.Controls.Add(this.label2);
            this.grpDepositInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepositInfo.Location = new System.Drawing.Point(413, 107);
            this.grpDepositInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDepositInfo.Name = "grpDepositInfo";
            this.grpDepositInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDepositInfo.Size = new System.Drawing.Size(393, 187);
            this.grpDepositInfo.TabIndex = 2;
            this.grpDepositInfo.TabStop = false;
            this.grpDepositInfo.Text = "Deposit Information";
            // 
            // txtNumChecks
            // 
            this.txtNumChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumChecks.Location = new System.Drawing.Point(148, 138);
            this.txtNumChecks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumChecks.Name = "txtNumChecks";
            this.txtNumChecks.Size = new System.Drawing.Size(197, 23);
            this.txtNumChecks.TabIndex = 9;
            this.txtNumChecks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "# of Checks:";
            // 
            // txtCheckAmt
            // 
            this.txtCheckAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckAmt.Location = new System.Drawing.Point(148, 106);
            this.txtCheckAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCheckAmt.Name = "txtCheckAmt";
            this.txtCheckAmt.Size = new System.Drawing.Size(197, 23);
            this.txtCheckAmt.TabIndex = 7;
            this.txtCheckAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Check $:";
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmt.Location = new System.Drawing.Point(148, 74);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(197, 23);
            this.txtCashAmt.TabIndex = 5;
            this.txtCashAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Cash $:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(148, 42);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(197, 23);
            this.txtAccountNumber.TabIndex = 3;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account #:";
            // 
            // btnMakeDeposit
            // 
            this.btnMakeDeposit.BackColor = System.Drawing.Color.Green;
            this.btnMakeDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDeposit.ForeColor = System.Drawing.Color.White;
            this.btnMakeDeposit.Location = new System.Drawing.Point(613, 302);
            this.btnMakeDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeDeposit.Name = "btnMakeDeposit";
            this.btnMakeDeposit.Size = new System.Drawing.Size(193, 46);
            this.btnMakeDeposit.TabIndex = 3;
            this.btnMakeDeposit.Text = "Make &Deposit";
            this.btnMakeDeposit.UseVisualStyleBackColor = false;
            this.btnMakeDeposit.Click += new System.EventHandler(this.btnMakeDeposit_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Enabled = false;
            this.btnNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.Location = new System.Drawing.Point(413, 302);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(193, 46);
            this.btnNewAccount.TabIndex = 4;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // lblDepositSummary
            // 
            this.lblDepositSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepositSummary.Location = new System.Drawing.Point(55, 70);
            this.lblDepositSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepositSummary.Name = "lblDepositSummary";
            this.lblDepositSummary.Size = new System.Drawing.Size(343, 240);
            this.lblDepositSummary.TabIndex = 5;
            this.lblDepositSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deposit Summary";
            // 
            // lblTotalDisplay
            // 
            this.lblTotalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisplay.Location = new System.Drawing.Point(55, 368);
            this.lblTotalDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDisplay.Name = "lblTotalDisplay";
            this.lblTotalDisplay.Size = new System.Drawing.Size(752, 37);
            this.lblTotalDisplay.TabIndex = 7;
            this.lblTotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.DarkRed;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(709, 421);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(97, 46);
            this.btnLeave.TabIndex = 8;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 505);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lblTotalDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDepositSummary);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.btnMakeDeposit);
            this.Controls.Add(this.grpDepositInfo);
            this.Controls.Add(this.txtAccountHolder);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a Deposit";
            this.grpDepositInfo.ResumeLayout(false);
            this.grpDepositInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.GroupBox grpDepositInfo;
        private System.Windows.Forms.TextBox txtNumChecks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeDeposit;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Label lblDepositSummary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalDisplay;
        private System.Windows.Forms.Button btnLeave;
    }
}

