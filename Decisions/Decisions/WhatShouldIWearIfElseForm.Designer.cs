namespace Decisions
{
    partial class WhatShouldIWearIfElseForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWhatToWear = new System.Windows.Forms.Button();
            this.btnOtherSuggestions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the High Temperature for today?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnWhatToWear
            // 
            this.btnWhatToWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatToWear.Location = new System.Drawing.Point(15, 107);
            this.btnWhatToWear.Name = "btnWhatToWear";
            this.btnWhatToWear.Size = new System.Drawing.Size(376, 40);
            this.btnWhatToWear.TabIndex = 2;
            this.btnWhatToWear.Text = "Should I wear my jacket?";
            this.btnWhatToWear.UseVisualStyleBackColor = true;
            this.btnWhatToWear.Click += new System.EventHandler(this.btnWhatToWear_Click);
            // 
            // btnOtherSuggestions
            // 
            this.btnOtherSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherSuggestions.Location = new System.Drawing.Point(15, 153);
            this.btnOtherSuggestions.Name = "btnOtherSuggestions";
            this.btnOtherSuggestions.Size = new System.Drawing.Size(376, 40);
            this.btnOtherSuggestions.TabIndex = 3;
            this.btnOtherSuggestions.Text = "Any other wardrobe suggestions?";
            this.btnOtherSuggestions.UseVisualStyleBackColor = true;
            this.btnOtherSuggestions.Click += new System.EventHandler(this.btnOtherSuggestions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Will it be sunny? (Yes/No)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 5;
            // 
            // WhatShouldIWearIfElseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 210);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtherSuggestions);
            this.Controls.Add(this.btnWhatToWear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "WhatShouldIWearIfElseForm";
            this.Text = "What should I wear?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWhatToWear;
        private System.Windows.Forms.Button btnOtherSuggestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}