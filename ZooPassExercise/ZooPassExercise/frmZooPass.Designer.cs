namespace ZooPassExercise
{
    partial class frmZooPass
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemovePass = new System.Windows.Forms.Button();
            this.lblNumPasses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPasses = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMonkeyShow = new System.Windows.Forms.CheckBox();
            this.chkTrainor = new System.Windows.Forms.CheckBox();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPassLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(272, 555);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 33);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAddPass
            // 
            this.btnAddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPass.Location = new System.Drawing.Point(509, 132);
            this.btnAddPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPass.Name = "btnAddPass";
            this.btnAddPass.Size = new System.Drawing.Size(115, 33);
            this.btnAddPass.TabIndex = 28;
            this.btnAddPass.Text = "Add";
            this.btnAddPass.UseVisualStyleBackColor = true;
            this.btnAddPass.Click += new System.EventHandler(this.btnAddPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pass Length";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(189, 459);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 33);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemovePass
            // 
            this.btnRemovePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePass.Location = new System.Drawing.Point(67, 459);
            this.btnRemovePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePass.Name = "btnRemovePass";
            this.btnRemovePass.Size = new System.Drawing.Size(115, 33);
            this.btnRemovePass.TabIndex = 25;
            this.btnRemovePass.Text = "Remove";
            this.btnRemovePass.UseVisualStyleBackColor = true;
            this.btnRemovePass.Click += new System.EventHandler(this.RemovePass_Click);
            // 
            // lblNumPasses
            // 
            this.lblNumPasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumPasses.Location = new System.Drawing.Point(509, 466);
            this.lblNumPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPasses.Name = "lblNumPasses";
            this.lblNumPasses.Size = new System.Drawing.Size(88, 28);
            this.lblNumPasses.TabIndex = 23;
            this.lblNumPasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Passes";
            // 
            // lstPasses
            // 
            this.lstPasses.FormattingEnabled = true;
            this.lstPasses.ItemHeight = 16;
            this.lstPasses.Location = new System.Drawing.Point(67, 310);
            this.lstPasses.Margin = new System.Windows.Forms.Padding(4);
            this.lstPasses.Name = "lstPasses";
            this.lstPasses.Size = new System.Drawing.Size(529, 132);
            this.lstPasses.TabIndex = 20;
            this.lstPasses.DoubleClick += new System.EventHandler(this.lstPasses_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAdult);
            this.groupBox2.Controls.Add(this.rdoChild);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(73, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(135, 118);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Checked = true;
            this.rdoAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(32, 74);
            this.rdoAdult.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(68, 24);
            this.rdoAdult.TabIndex = 1;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adult";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChild.Location = new System.Drawing.Point(32, 33);
            this.rdoChild.Margin = new System.Windows.Forms.Padding(4);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(68, 24);
            this.rdoChild.TabIndex = 0;
            this.rdoChild.Text = "Child";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonkeyShow);
            this.groupBox1.Controls.Add(this.chkTrainor);
            this.groupBox1.Controls.Add(this.chkVip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(243, 155);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkMonkeyShow
            // 
            this.chkMonkeyShow.AutoSize = true;
            this.chkMonkeyShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonkeyShow.Location = new System.Drawing.Point(28, 106);
            this.chkMonkeyShow.Margin = new System.Windows.Forms.Padding(4);
            this.chkMonkeyShow.Name = "chkMonkeyShow";
            this.chkMonkeyShow.Size = new System.Drawing.Size(134, 24);
            this.chkMonkeyShow.TabIndex = 2;
            this.chkMonkeyShow.Text = "Monkey Show";
            this.chkMonkeyShow.UseVisualStyleBackColor = true;
            // 
            // chkTrainor
            // 
            this.chkTrainor.AutoSize = true;
            this.chkTrainor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrainor.Location = new System.Drawing.Point(28, 70);
            this.chkTrainor.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrainor.Name = "chkTrainor";
            this.chkTrainor.Size = new System.Drawing.Size(154, 24);
            this.chkTrainor.TabIndex = 1;
            this.chkTrainor.Text = "Meet the Trainor";
            this.chkTrainor.UseVisualStyleBackColor = true;
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVip.Location = new System.Drawing.Point(28, 38);
            this.chkVip.Margin = new System.Windows.Forms.Padding(4);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(57, 24);
            this.chkVip.TabIndex = 0;
            this.chkVip.Text = "VIP";
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "# of Passes:";
            // 
            // cboPassLength
            // 
            this.cboPassLength.FormattingEnabled = true;
            this.cboPassLength.Location = new System.Drawing.Point(67, 119);
            this.cboPassLength.Margin = new System.Windows.Forms.Padding(4);
            this.cboPassLength.Name = "cboPassLength";
            this.cboPassLength.Size = new System.Drawing.Size(160, 24);
            this.cboPassLength.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Zoo Pass Purchase";
            // 
            // frmZooPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 624);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemovePass);
            this.Controls.Add(this.lblNumPasses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPasses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPassLength);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmZooPass";
            this.Text = "Zoo Pass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZooPass_FormClosing);
            this.Load += new System.EventHandler(this.frmZooPass_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemovePass;
        private System.Windows.Forms.Label lblNumPasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPasses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonkeyShow;
        private System.Windows.Forms.CheckBox chkTrainor;
        private System.Windows.Forms.CheckBox chkVip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPassLength;
        private System.Windows.Forms.Label label1;
    }
}

