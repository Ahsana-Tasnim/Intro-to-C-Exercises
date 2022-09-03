namespace MacBookOrderForm
{
    partial class frmMacBookOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.rdo13 = new System.Windows.Forms.RadioButton();
            this.grpProcessorStorage = new System.Windows.Forms.GroupBox();
            this.rdoModel3 = new System.Windows.Forms.RadioButton();
            this.rdoModel2 = new System.Windows.Forms.RadioButton();
            this.rdoModel1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFinalCut = new System.Windows.Forms.CheckBox();
            this.chkLogic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpProcessorStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo15);
            this.groupBox1.Controls.Add(this.rdo13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(341, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo15.Location = new System.Drawing.Point(197, 38);
            this.rdo15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(54, 24);
            this.rdo15.TabIndex = 1;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15\"";
            this.rdo15.UseVisualStyleBackColor = true;
            // 
            // rdo13
            // 
            this.rdo13.AutoSize = true;
            this.rdo13.Checked = true;
            this.rdo13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo13.Location = new System.Drawing.Point(88, 38);
            this.rdo13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo13.Name = "rdo13";
            this.rdo13.Size = new System.Drawing.Size(54, 24);
            this.rdo13.TabIndex = 0;
            this.rdo13.TabStop = true;
            this.rdo13.Text = "13\"";
            this.rdo13.UseVisualStyleBackColor = true;
            // 
            // grpProcessorStorage
            // 
            this.grpProcessorStorage.Controls.Add(this.rdoModel3);
            this.grpProcessorStorage.Controls.Add(this.rdoModel2);
            this.grpProcessorStorage.Controls.Add(this.rdoModel1);
            this.grpProcessorStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProcessorStorage.Location = new System.Drawing.Point(55, 155);
            this.grpProcessorStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProcessorStorage.Name = "grpProcessorStorage";
            this.grpProcessorStorage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProcessorStorage.Size = new System.Drawing.Size(513, 185);
            this.grpProcessorStorage.TabIndex = 2;
            this.grpProcessorStorage.TabStop = false;
            this.grpProcessorStorage.Text = "Processor/Storage";
            // 
            // rdoModel3
            // 
            this.rdoModel3.AutoSize = true;
            this.rdoModel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModel3.Location = new System.Drawing.Point(48, 114);
            this.rdoModel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoModel3.Name = "rdoModel3";
            this.rdoModel3.Size = new System.Drawing.Size(305, 24);
            this.rdoModel3.TabIndex = 2;
            this.rdoModel3.TabStop = true;
            this.rdoModel3.Text = "3.1 Ghz Processor / 256 GB Storage";
            this.rdoModel3.UseVisualStyleBackColor = true;
            // 
            // rdoModel2
            // 
            this.rdoModel2.AutoSize = true;
            this.rdoModel2.Checked = true;
            this.rdoModel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModel2.Location = new System.Drawing.Point(48, 81);
            this.rdoModel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoModel2.Name = "rdoModel2";
            this.rdoModel2.Size = new System.Drawing.Size(305, 24);
            this.rdoModel2.TabIndex = 1;
            this.rdoModel2.TabStop = true;
            this.rdoModel2.Text = "2.3 Ghz Processor / 256 GB Storage";
            this.rdoModel2.UseVisualStyleBackColor = true;
            // 
            // rdoModel1
            // 
            this.rdoModel1.AutoSize = true;
            this.rdoModel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModel1.Location = new System.Drawing.Point(48, 48);
            this.rdoModel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoModel1.Name = "rdoModel1";
            this.rdoModel1.Size = new System.Drawing.Size(305, 24);
            this.rdoModel1.TabIndex = 0;
            this.rdoModel1.TabStop = true;
            this.rdoModel1.Text = "2.3 Ghz Processor / 128 GB Storage";
            this.rdoModel1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pre-installed Software";
            // 
            // chkFinalCut
            // 
            this.chkFinalCut.AutoSize = true;
            this.chkFinalCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinalCut.Location = new System.Drawing.Point(59, 399);
            this.chkFinalCut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFinalCut.Name = "chkFinalCut";
            this.chkFinalCut.Size = new System.Drawing.Size(145, 24);
            this.chkFinalCut.TabIndex = 4;
            this.chkFinalCut.Text = "Final Cut Pro X";
            this.chkFinalCut.UseVisualStyleBackColor = true;
            // 
            // chkLogic
            // 
            this.chkLogic.AutoSize = true;
            this.chkLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogic.Location = new System.Drawing.Point(59, 432);
            this.chkLogic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLogic.Name = "chkLogic";
            this.chkLogic.Size = new System.Drawing.Size(119, 24);
            this.chkLogic.TabIndex = 5;
            this.chkLogic.Text = "Logic Pro X";
            this.chkLogic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(320, 399);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(248, 50);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(59, 480);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(509, 66);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMacBookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 590);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkLogic);
            this.Controls.Add(this.chkFinalCut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpProcessorStorage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMacBookOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacBook Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpProcessorStorage.ResumeLayout(false);
            this.grpProcessorStorage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo15;
        private System.Windows.Forms.RadioButton rdo13;
        private System.Windows.Forms.GroupBox grpProcessorStorage;
        private System.Windows.Forms.RadioButton rdoModel3;
        private System.Windows.Forms.RadioButton rdoModel2;
        private System.Windows.Forms.RadioButton rdoModel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFinalCut;
        private System.Windows.Forms.CheckBox chkLogic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
    }
}

