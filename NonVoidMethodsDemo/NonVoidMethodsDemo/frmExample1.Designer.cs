namespace NonVoidMethodsDemo
{
    partial class frmExample1
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindLargest = new System.Windows.Forms.Button();
            this.btnIsFirstOneBigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(245, 46);
            this.txtFirstNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(132, 22);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(245, 78);
            this.txtSecondNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(132, 22);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number:";
            // 
            // btnFindLargest
            // 
            this.btnFindLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindLargest.Location = new System.Drawing.Point(219, 128);
            this.btnFindLargest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindLargest.Name = "btnFindLargest";
            this.btnFindLargest.Size = new System.Drawing.Size(160, 53);
            this.btnFindLargest.TabIndex = 4;
            this.btnFindLargest.Text = "Find Largest";
            this.btnFindLargest.UseVisualStyleBackColor = true;
            this.btnFindLargest.Click += new System.EventHandler(this.btnFindLargest_Click);
            // 
            // btnIsFirstOneBigger
            // 
            this.btnIsFirstOneBigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsFirstOneBigger.Location = new System.Drawing.Point(219, 208);
            this.btnIsFirstOneBigger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsFirstOneBigger.Name = "btnIsFirstOneBigger";
            this.btnIsFirstOneBigger.Size = new System.Drawing.Size(160, 53);
            this.btnIsFirstOneBigger.TabIndex = 5;
            this.btnIsFirstOneBigger.Text = "Is First Bigger?";
            this.btnIsFirstOneBigger.UseVisualStyleBackColor = true;
            this.btnIsFirstOneBigger.Click += new System.EventHandler(this.btnIsFirstOneBigger_Click);
            // 
            // frmExample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 346);
            this.Controls.Add(this.btnIsFirstOneBigger);
            this.Controls.Add(this.btnFindLargest);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExample1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindLargest;
        private System.Windows.Forms.Button btnIsFirstOneBigger;
    }
}