namespace DecisionsExercises2
{
    partial class frmEx3FruitStand
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
            this.lblCost = new System.Windows.Forms.Label();
            this.btnShowCost = new System.Windows.Forms.Button();
            this.txtPoundsOfApples = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaymentAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Location = new System.Drawing.Point(595, 146);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(148, 39);
            this.lblCost.TabIndex = 10;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowCost
            // 
            this.btnShowCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCost.Location = new System.Drawing.Point(595, 81);
            this.btnShowCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCost.Name = "btnShowCost";
            this.btnShowCost.Size = new System.Drawing.Size(148, 57);
            this.btnShowCost.TabIndex = 9;
            this.btnShowCost.Text = "Show Cost";
            this.btnShowCost.UseVisualStyleBackColor = true;
            this.btnShowCost.Click += new System.EventHandler(this.btnShowCost_Click);
            // 
            // txtPoundsOfApples
            // 
            this.txtPoundsOfApples.Location = new System.Drawing.Point(595, 49);
            this.txtPoundsOfApples.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPoundsOfApples.Name = "txtPoundsOfApples";
            this.txtPoundsOfApples.Size = new System.Drawing.Size(147, 22);
            this.txtPoundsOfApples.TabIndex = 8;
            this.txtPoundsOfApples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "How many pounds of apples do you wish to order?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cost:";
            // 
            // txtPaymentAmt
            // 
            this.txtPaymentAmt.Location = new System.Drawing.Point(595, 203);
            this.txtPaymentAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentAmt.Name = "txtPaymentAmt";
            this.txtPaymentAmt.Size = new System.Drawing.Size(147, 22);
            this.txtPaymentAmt.TabIndex = 13;
            this.txtPaymentAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter payment amount:";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(341, 249);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(401, 57);
            this.btnCheckout.TabIndex = 14;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // frmEx3FruitStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 354);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtPaymentAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnShowCost);
            this.Controls.Add(this.txtPoundsOfApples);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEx3FruitStand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 3 - Fruit Stand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnShowCost;
        private System.Windows.Forms.TextBox txtPoundsOfApples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaymentAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckout;
    }
}