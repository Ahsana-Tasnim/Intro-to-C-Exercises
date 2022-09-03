namespace PizzaCalculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoExtraLarge = new System.Windows.Forms.RadioButton();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpTotals = new System.Windows.Forms.GroupBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeliveryCharge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(259, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 160);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaCalculator.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 161);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoExtraLarge);
            this.grpSize.Controls.Add(this.rdoLarge);
            this.grpSize.Controls.Add(this.rdoMedium);
            this.grpSize.Controls.Add(this.rdoSmall);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(17, 183);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4);
            this.grpSize.Size = new System.Drawing.Size(267, 233);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Choose your pizza size";
            // 
            // rdoExtraLarge
            // 
            this.rdoExtraLarge.AutoSize = true;
            this.rdoExtraLarge.Location = new System.Drawing.Point(59, 178);
            this.rdoExtraLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExtraLarge.Name = "rdoExtraLarge";
            this.rdoExtraLarge.Size = new System.Drawing.Size(139, 22);
            this.rdoExtraLarge.TabIndex = 3;
            this.rdoExtraLarge.Tag = "18";
            this.rdoExtraLarge.Text = "Extra Large (16\")";
            this.rdoExtraLarge.UseVisualStyleBackColor = true;
            this.rdoExtraLarge.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(59, 135);
            this.rdoLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(101, 22);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.Tag = "13";
            this.rdoLarge.Text = "Large (12\")";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(59, 92);
            this.rdoMedium.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(109, 22);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.Tag = "11";
            this.rdoMedium.Text = "Medium (9\")";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(59, 49);
            this.rdoSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(93, 22);
            this.rdoSmall.TabIndex = 1;
            this.rdoSmall.Tag = "8";
            this.rdoSmall.Text = "Small (6\")";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkGreenPeppers);
            this.grpToppings.Controls.Add(this.chkExtraCheese);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(328, 183);
            this.grpToppings.Margin = new System.Windows.Forms.Padding(4);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Padding = new System.Windows.Forms.Padding(4);
            this.grpToppings.Size = new System.Drawing.Size(267, 233);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Choose your toppings";
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(55, 174);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(4);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(94, 22);
            this.chkPineapple.TabIndex = 4;
            this.chkPineapple.Tag = "1";
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(55, 143);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(70, 22);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(55, 112);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(130, 22);
            this.chkGreenPeppers.TabIndex = 2;
            this.chkGreenPeppers.Tag = "1";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(55, 81);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(119, 22);
            this.chkExtraCheese.TabIndex = 1;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(55, 50);
            this.chkPepperoni.Margin = new System.Windows.Forms.Padding(4);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(97, 22);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Tag = "1";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.Click += new System.EventHandler(this.rdoAndCheckBox_Click);
            // 
            // grpTotals
            // 
            this.grpTotals.Controls.Add(this.lblGrandTotal);
            this.grpTotals.Controls.Add(this.label7);
            this.grpTotals.Controls.Add(this.lblTax);
            this.grpTotals.Controls.Add(this.label6);
            this.grpTotals.Controls.Add(this.lblDeliveryCharge);
            this.grpTotals.Controls.Add(this.label5);
            this.grpTotals.Controls.Add(this.lblSubtotal);
            this.grpTotals.Controls.Add(this.label2);
            this.grpTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotals.Location = new System.Drawing.Point(628, 183);
            this.grpTotals.Margin = new System.Windows.Forms.Padding(4);
            this.grpTotals.Name = "grpTotals";
            this.grpTotals.Padding = new System.Windows.Forms.Padding(4);
            this.grpTotals.Size = new System.Drawing.Size(380, 233);
            this.grpTotals.TabIndex = 5;
            this.grpTotals.TabStop = false;
            this.grpTotals.Text = "Choose your toppings";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Location = new System.Drawing.Point(208, 171);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(88, 32);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grand Total:";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(208, 130);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(88, 32);
            this.lblTax.TabIndex = 5;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tax:";
            // 
            // lblDeliveryCharge
            // 
            this.lblDeliveryCharge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDeliveryCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeliveryCharge.Location = new System.Drawing.Point(208, 90);
            this.lblDeliveryCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryCharge.Name = "lblDeliveryCharge";
            this.lblDeliveryCharge.Size = new System.Drawing.Size(88, 32);
            this.lblDeliveryCharge.TabIndex = 3;
            this.lblDeliveryCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Delivery Charge:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(208, 49);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 32);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "To order pizza, enter email address and click submit order\r\n";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(328, 430);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Crimson;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(628, 425);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(380, 37);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 516);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpTotals);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpTotals.ResumeLayout(false);
            this.grpTotals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdoExtraLarge;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grpTotals;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDeliveryCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
    }
}

