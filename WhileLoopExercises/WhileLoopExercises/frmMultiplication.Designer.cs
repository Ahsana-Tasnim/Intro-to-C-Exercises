namespace WhileLoopExercises
{
    partial class frmMultiplication
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
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.lstMultiplicationTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a number from the dropdown";
            // 
            // cboNumber
            // 
            this.cboNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Location = new System.Drawing.Point(44, 73);
            this.cboNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(305, 28);
            this.cboNumber.TabIndex = 1;
            this.cboNumber.SelectionChangeCommitted += new System.EventHandler(this.cboNumber_SelectionChangeCommitted);
            // 
            // lstMultiplicationTable
            // 
            this.lstMultiplicationTable.FormattingEnabled = true;
            this.lstMultiplicationTable.ItemHeight = 16;
            this.lstMultiplicationTable.Location = new System.Drawing.Point(44, 110);
            this.lstMultiplicationTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMultiplicationTable.Name = "lstMultiplicationTable";
            this.lstMultiplicationTable.Size = new System.Drawing.Size(305, 164);
            this.lstMultiplicationTable.TabIndex = 2;
            // 
            // frmMultiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 334);
            this.Controls.Add(this.lstMultiplicationTable);
            this.Controls.Add(this.cboNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMultiplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplication Table";
            this.Load += new System.EventHandler(this.frmMultiplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.ListBox lstMultiplicationTable;
    }
}